import React from "react";
import {
  Box,
  Button,
  ButtonText,
  Heading,
  Image,
  Input,
  InputField,
  Text,
} from "@gluestack-ui/themed";

import logo from "../../assets/logo.png";

export function Login() {
  return (
    <Box flex={1} bg="$info600" h="100%" alignItems="center">
      <Box>{/* <Image size="sm" source={logo} alt="logo do avisaí" /> */}</Box>

      <Box
        w="$full"
        bg="$white"
        flex={1}
        alignItems="center"
        p="$4"
        alignContent="center"
        justifyContent="center"
      >
        <Heading mb="$2" size="2xl">
          Acessar minha conta
        </Heading>
        <Input
          my="$2"
          variant="outline"
          size="xl"
          isDisabled={false}
          isInvalid={false}
          isReadOnly={false}
        >
          <InputField placeholder="e-mail" />
        </Input>

        <Input
          variant="outline"
          size="xl"
          my="$2"
          isDisabled={false}
          isInvalid={false}
          isReadOnly={false}
        >
          <InputField placeholder="senha" type="password" />
        </Input>

        <Button
          w="$full"
          size="xl"
          variant="solid"
          action="primary"
          isDisabled={false}
          isFocusVisible={false}
        >
          <ButtonText>Login</ButtonText>
        </Button>
      </Box>
    </Box>
  );
}
