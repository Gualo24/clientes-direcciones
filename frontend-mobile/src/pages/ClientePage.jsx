import { Avatar, Box, Center, FlatList, Heading, HStack, Spacer, Text, VStack } from 'native-base';
import React, { useEffect, useState } from 'react'
import { ProvidersClienteGet } from "../providers/Cliente_Providers";

export default function ClientePage({ navigation, route }) {
    const [cliente, setCliente] = useState({})
    const { idCliente } = route.params;

    useEffect(async () => {
        const rst = await ProvidersClienteGet(idCliente);
        if (rst.isSuccess) {
            setCliente(rst.result);
        }
    }, [ProvidersClienteGet])

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
                        Direcciones
                    </Heading>
                    <FlatList data={cliente.direcciones} renderItem={({
                        item
                    }) => <Box borderBottomWidth="1" _dark={{
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
                        </Box>} keyExtractor={item => item.id} />
                </Box>
            </>)}
        </>
    )
}

