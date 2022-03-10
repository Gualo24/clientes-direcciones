import { Actionsheet, Avatar, Box, Button, Center, FlatList, Heading, HStack, Spacer, Text, VStack, Pressable } from 'native-base';
import React, { useEffect, useState } from 'react'
import { MaterialIcons } from "@expo/vector-icons";
import { ProvidersClienteGet } from "../providers/Cliente_Providers";
import { useFocusEffect } from '@react-navigation/native';
import { ProvidersDireccionDelete } from "../providers/Direccion_Providers";


export default function ClientePage({ navigation, route }) {
    const [showModal, setShowModal] = useState(false);
    const [showMenu, setShowMenu] = useState(false);
    const [direccion, setDireccion] = useState({})
    const [cliente, setCliente] = useState({})

    const { idCliente } = route?.params;

    async function GetCliente() {
        const rst = await ProvidersClienteGet(idCliente);
        if (rst.isSuccess) {
            setCliente(rst.result);
        }
    }

    useEffect(async () => {
        await GetCliente()
    }, [])

    useFocusEffect(
        React.useCallback(async () => {
            await GetCliente()
            return () => { };
        }, [])
    );

    function SeleccionarDireccion(data){
        setDireccion(data);
        setShowMenu(true);
    }

    async function EliminarDireccion(){
        const rst = await ProvidersDireccionDelete(direccion.idDireccion)
        if (rst.isSuccess) {
            setShowMenu(false);
            await GetCliente();
        }
    }

    return (
        <>
            {cliente && (<>
                <Center marginTop={3}>
                    <Avatar size="80px" source={{ uri: cliente.avatarUrl }} />
                    <Text>{cliente.nombres}</Text>
                    <Text>{cliente.apellidos}</Text>
                    <Text>{cliente.telefono}</Text>
                    <Text>{cliente.correoElectronico}</Text>
                </Center>
                <Box>
                    <Heading fontSize="xl" p="4" pb="3">
                        <Text>Direcciones</Text>
                        <Button variant="ghost" onPress={() => navigation.navigate('crear-direccion', { idCliente: cliente.idCliente })}> Agregar</Button>
                    </Heading>
                    <FlatList data={cliente.direcciones} renderItem={({
                        item
                    }) => <Pressable onLongPress={() => SeleccionarDireccion(item)}>
                            <Box key={item.idDireccion} borderBottomWidth="1" _dark={{
                                borderColor: "gray.600"
                            }} borderColor="coolGray.200" pl="4" pr="5" py="2">
                                <HStack space={3} justifyContent="space-between">
                                    <VStack>
                                        <Text _dark={{
                                            color: "warmGray.50"
                                        }} color="coolGray.800" bold>
                                            {item.referencia}
                                        </Text>
                                        <Text color="coolGray.600" _dark={{
                                            color: "warmGray.200"
                                        }}>
                                            {item.detalle}
                                        </Text>
                                        <Text color="coolGray.600" _dark={{
                                            color: "warmGray.200"
                                        }}>
                                            {item.provincia}
                                        </Text>
                                        <Text color="coolGray.600" _dark={{
                                            color: "warmGray.200"
                                        }}>
                                            {item.municipio}
                                        </Text>
                                    </VStack>
                                    <Spacer />
                                </HStack>
                            </Box>
                        </Pressable>} keyExtractor={item => item.idDireccion} />
                </Box>
            </>)}

            <Actionsheet isOpen={showMenu}
                onClose={() => setShowMenu(false)} >
                <Actionsheet.Content>
                    <Actionsheet.Item>Editar</Actionsheet.Item>
                    <Actionsheet.Item onPress={EliminarDireccion}>Eliminar</Actionsheet.Item>
                    <Actionsheet.Item onPress={() => setShowMenu(false)}>Cancel</Actionsheet.Item>
                </Actionsheet.Content>
            </Actionsheet>
        </>
    )
}



