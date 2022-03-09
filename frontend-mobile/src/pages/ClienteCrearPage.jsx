import React, { useState } from 'react'

import { Box, Button, Center, FormControl, Input, VStack, useToast } from 'native-base';

import { ProvidersClienteCreate } from "../providers/Cliente_Providers";

export default function ClienteCrearPage({ navigation, route }) {
    const [formData, setData] = useState({});
    const toast = useToast();

    const onSubmit = async () => {
        const cliente = {
            nombres: formData.nombres,
            apellidos: formData.apellidos,
            correoElectronico: formData.correoElectronico,
            telefono: formData.telefono
        }

        const rst = await ProvidersClienteCreate(cliente);
        if (rst.isSuccess) {
            toast.show({
                title: "Todo salio bien",
                status: "success",
                description: "Se creo el cliente"
            });
            navigation.goBack();
        } else {
            toast.show({
                title: "Algo salio mal",
                status: "error",
                description: "Favor complete el formulario"
            })
        }
    };


    return (
        <>
            <Center marginTop={10}>
                <VStack width="90%" mx="3" maxW="300px" >
                    <FormControl isRequired>
                        <FormControl.Label _text={{ bold: true }}>Nombres</FormControl.Label>
                        <Input placeholder="John"
                            variant="underlined"
                            onChangeText={value => setData({ ...formData, nombres: value })} />
                    </FormControl>
                    <FormControl isRequired marginTop={2}>
                        <FormControl.Label _text={{ bold: true }}>Apellidos</FormControl.Label>
                        <Input placeholder="Due"
                            variant="underlined"
                            onChangeText={value => setData({ ...formData, apellidos: value })} />
                    </FormControl>
                    <FormControl isRequired marginTop={2}>
                        <FormControl.Label _text={{ bold: true }}>Correo Electronico</FormControl.Label>
                        <Input placeholder="JohnDue@dominio.com"
                            variant="underlined"
                            onChangeText={value => setData({ ...formData, correoElectronico: value })} />
                    </FormControl>
                    <FormControl isRequired marginTop={2}>
                        <FormControl.Label _text={{ bold: true }}>Telefono</FormControl.Label>
                        <Input placeholder="(809) 555-5555"
                            variant="underlined"
                            onChangeText={value => setData({ ...formData, telefono: value })} />
                    </FormControl>
                    <Button onPress={onSubmit} mt="5" colorScheme="cyan">
                        Submit
                    </Button>
                </VStack>
            </Center>
        </>
    )
}
