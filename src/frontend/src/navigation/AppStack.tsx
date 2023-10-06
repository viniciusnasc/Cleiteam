import React from 'react';
import {createNativeStackNavigator} from '@react-navigation/native-stack';
import {TabStack} from './TabStack';

const Stack = createNativeStackNavigator();

export function AppStack() {
  return (
    <Stack.Navigator>
      <Stack.Screen
        name="TabStack"
        component={TabStack}
        options={() => {
          return {
            headerShown: false,
          };
        }}
      />
    </Stack.Navigator>
  );
}
