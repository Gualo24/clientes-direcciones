import React, { useState, useEffect } from 'react'
import { Box, FlatList, Heading, Avatar, HStack, VStack, Text, Spacer, Pressable, Center, NativeBaseProvider, Alert } from "native-base";
import { ProvidersClienteGetAll } from "../providers/Cliente_Providers";

import { useFocusEffect } from '@react-navigation/native';


export default function ClientesPage({ navigation, route }) {

  const [clientes, setclientes] = useState([])


  useEffect(() => {
    GetClientes()
  }, [])

  useFocusEffect(
    React.useCallback(async () => {
      await GetClientes()
      return  () => {   };
    }, [])
  );

  async function GetClientes() {
    const rst = await ProvidersClienteGetAll();
    if (rst.isSuccess) {
      setclientes(rst.result)
    }else{

    }
  }

  return (
    <>
      <Box>
        <Heading fontSize="xl" p="4" pb="3">
          Listado de clientes
        </Heading>
        <FlatList data={clientes} renderItem={({
          item
        }) => <Pressable key={item.idCliente}  onPress={() => { navigation.navigate('cliente', { idCliente: item.idCliente }) }}>
            <Box borderBottomWidth="1" _dark={{
              borderColor: "gray.600"
            }} borderColor="coolGray.200" pl="4" pr="5" py="2">
              <HStack space={3} justifyContent="space-between">
                <Avatar size="48px" source={{ uri: item.avatarUrl }} />
                <VStack>
                  <Text _dark={{ color: "warmGray.50" }} color="coolGray.800" bold> {item.nombres} </Text>
                  <Text color="coolGray.600" _dark={{ color: "warmGray.200" }}> {item.apellidos}</Text>
                </VStack>
                <Spacer />
                <VStack>
                  <Text fontSize="xs" _dark={{ color: "warmGray.50" }} color="coolGray.800" alignSelf="flex-end">
                    {item.correoElectronico}
                  </Text>
                  <Text fontSize="xs" _dark={{ color: "warmGray.50" }} color="coolGray.800" alignSelf="flex-end">
                    {item.telefono}
                  </Text>
                </VStack>
              </HStack>
            </Box>
          </Pressable>} keyExtractor={item => item.idCliente} />
      </Box>
    </>
  )
}

