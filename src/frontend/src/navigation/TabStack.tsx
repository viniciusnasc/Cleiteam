import React from "react";
import { createBottomTabNavigator } from "@react-navigation/bottom-tabs";
import { Home } from "../screens/Home";
import { Login } from "../screens/Login";
import { Register } from "../screens/Register";

const { Navigator, Screen } = createBottomTabNavigator();

export function TabStack() {
  return (
    <Navigator
      screenOptions={{
        headerShown: false,
        tabBarStyle: {
          height: 90,
          borderTopWidth: 2,
        },
        tabBarHideOnKeyboard: true,
        tabBarShowLabel: false,
      }}
    >
      <Screen
        name="Login"
        component={Login}
        options={{
          tabBarLabel: "Início",
        }}
      />
      <Screen
        name="Home"
        component={Home}
        options={{
          tabBarLabel: "Início",
        }}
      />

      <Screen
        name="Register"
        component={Register}
        options={{
          tabBarLabel: "Novo registro",
        }}
      />
    </Navigator>
  );
}
