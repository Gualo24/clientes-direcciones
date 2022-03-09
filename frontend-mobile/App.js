import React from 'react';
import { NativeBaseProvider, Text, Box, Button, IconButton, Icon } from 'native-base';
import { MaterialIcons } from "@expo/vector-icons";
import { NavigationContainer } from '@react-navigation/native';
import { createNativeStackNavigator } from '@react-navigation/native-stack';

import ClientesPage from "./src/pages/ClientesPage";
import ClientePage from "./src/pages/ClientePage";
import ClienteCrearPage from "./src/pages/ClienteCrearPage";

const Stack = createNativeStackNavigator();

export default function App() {
  return (
    <NativeBaseProvider>
      <NavigationContainer>
        <Stack.Navigator>
          <Stack.Screen name="clientes"
            component={ClientesPage}
            options={({ navigation, route }) => ({
              headerRight: () => (
                <IconButton variant="ghost"
                  onPress={() => navigation.push('crear-cliente')}
                  _icon={{ as: MaterialIcons, name: "add" }} />
              ),
            })}
          />
          <Stack.Screen name="cliente" component={ClientePage} />
          <Stack.Screen name="crear-cliente" component={ClienteCrearPage} />
        </Stack.Navigator>
      </NavigationContainer>
    </NativeBaseProvider>
  );
}
