import React from 'react';

import {NavigationContainer} from '@react-navigation/native';

import {AppStack} from './AppStack';

export const AppNav = () => {
  return (
    <NavigationContainer>
      <AppStack />
    </NavigationContainer>
  );
};
