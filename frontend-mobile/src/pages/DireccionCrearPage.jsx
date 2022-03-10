import React, { useEffect, useState } from 'react'
import { Button, Center, FormControl, Input, Modal, Pressable, Select, TextArea, Text, VStack, FlatList, HStack, Box } from 'native-base';
import { ProvidersDireccionGetProvincias, ProvidersDireccionGetMunicipios, ProvidersDireccionCreate } from "../providers/Direccion_Providers";


export default function DireccionCrearPage({ navigation, route }) {
    const [formData, setData] = useState({})
    const [provincias, setProvincias] = useState([])
    const [provincia, setProvincia] = useState({})
    const [municipios, setMunicipios] = useState([])
    const [municipio, setMunicipio] = useState({})
    const [showProvincia, setShowProvincia] = useState(false);
    const [showMunicipio, setShowMunicipio] = useState(false);
    const { idCliente } = route.params;

    useEffect(async () => {
        GetProvincias()
    }, [])

    async function GetProvincias() {
        const rst = await ProvidersDireccionGetProvincias();
        if (rst.isSuccess) {
            setProvincias(rst.result)
        }
    }

    async function onSubmit() {

        const data = {
            idCliente: idCliente,
            idProvincia: formData.idProvincia,
            idMunicipio: formData.idMunicipio,
            referencia: formData.referencia,
            detalle: formData.detalle
        }
        const rst = await ProvidersDireccionCreate(data);
        if (rst.isSuccess) {
            navigation.goBack();
        }else{

        }
    }

    async function SeleccionarProvincia(provincia) {
        setProvincia(provincia);
        setData({ ...formData, idProvincia: provincia.idProvincia })
        setMunicipio({})
        setShowProvincia(false);
        await GetMunicipios(provincia.idProvincia)
    }

    async function SeleccionarMunicipio(data) {
        setMunicipio(data);
        setData({ ...formData, idMunicipio: data.idMunicipio })
        setShowMunicipio(false);
    }

    async function GetMunicipios(id) {
        const rst = await ProvidersDireccionGetMunicipios(id)
        if (rst.isSuccess) {
            setMunicipios(rst.result)
        } else {
            setMunicipios([])
        }
    }

    return (
        <>
            <Center mt={5}>
                <VStack width="90%" mx="3" maxW="300px" >
                    <FormControl>
                        <FormControl.Label>Referencia</FormControl.Label>
                        <Input variant="underlined"
                            onChangeText={value => setData({ ...formData, referencia: value })} />
                    </FormControl>
                    <FormControl>
                        <FormControl.Label>Provincia</FormControl.Label>
                        <Pressable onPress={() => setShowProvincia(true)} >
                            <Center>
                                {(provincia && provincia?.provinciaNombre) ? (<Text>{provincia?.provinciaNombre}</Text>) : (<Text>Seleccionar provincia</Text>)}
                            </Center>
                        </Pressable>
                    </FormControl>
                    <FormControl>
                        <FormControl.Label>Municipio</FormControl.Label>
                        <Pressable onPress={() => setShowMunicipio(true)} >
                            <Center>
                                {(municipio && municipio.municipioNombre) ? (<Text>{municipio?.municipioNombre}</Text>) : (<Text>Seleccionar municipio</Text>)}
                            </Center>
                        </Pressable>
                    </FormControl>
                    <FormControl mt="3">
                        <FormControl.Label>Direccion</FormControl.Label>
                        <TextArea onChangeText={value => setData({ ...formData, detalle: value })}
                            h={20} w="100%"
                            placeholder="Calle, Numero, Apartamento, sector/barrio" />
                    </FormControl>
                    <Button onPress={onSubmit} mt="5" colorScheme="cyan">
                        Agregar direccion
                    </Button>
                </VStack>
            </Center>


            <Modal isOpen={showProvincia} onClose={() => setShowProvincia(false)}>
                <Modal.Content maxWidth="400px">
                    <Modal.CloseButton />
                    <Modal.Header>Provincias</Modal.Header>
                    <Modal.Body>
                        <FlatList data={provincias} renderItem={({
                            item
                        }) => <Pressable onPress={() => SeleccionarProvincia(item)}>
                                <Box key={item.idProvincia} borderBottomWidth="1" _dark={{
                                    borderColor: "gray.600"
                                }} borderColor="coolGray.200" pl="4" pr="5" py="2">
                                    <HStack space={3} justifyContent="space-between">
                                        <VStack>
                                            <Text _dark={{
                                                color: "warmGray.50"
                                            }} color="coolGray.800" bold>
                                                {item.provinciaNombre}
                                            </Text>
                                        </VStack>
                                    </HStack>
                                </Box>
                            </Pressable>} keyExtractor={item => item.idProvincia} />
                    </Modal.Body>
                    <Modal.Footer>
                        <Button.Group space={2}>
                            <Button variant="ghost" colorScheme="blueGray" onPress={() => {
                                setShowProvincia(false);
                            }}>
                                Cancel
                            </Button>
                        </Button.Group>
                    </Modal.Footer>
                </Modal.Content>
            </Modal>


            <Modal isOpen={showMunicipio} onClose={() => setShowMunicipio(false)}>
                <Modal.Content maxWidth="400px">
                    <Modal.CloseButton />
                    <Modal.Header>Municipios</Modal.Header>
                    <Modal.Body>
                        <FlatList data={municipios} renderItem={({
                            item
                        }) => <Pressable onPress={() => SeleccionarMunicipio(item)}>
                                <Box borderBottomWidth="1" _dark={{
                                    borderColor: "gray.600"
                                }} borderColor="coolGray.200" pl="4" pr="5" py="2">
                                    <HStack space={3} justifyContent="space-between">
                                        <VStack>
                                            <Text _dark={{
                                                color: "warmGray.50"
                                            }} color="coolGray.800" bold>
                                                {item.municipioNombre}
                                            </Text>
                                        </VStack>
                                    </HStack>
                                </Box>
                            </Pressable>} keyExtractor={item => item.idProvincia} />
                    </Modal.Body>
                    <Modal.Footer>
                        <Button.Group space={2}>
                            <Button variant="ghost" colorScheme="blueGray" onPress={() => {
                                setShowMunicipio(false);
                            }}>
                                Cancel
                            </Button>
                        </Button.Group>
                    </Modal.Footer>
                </Modal.Content>
            </Modal>

        </>
    )
}
