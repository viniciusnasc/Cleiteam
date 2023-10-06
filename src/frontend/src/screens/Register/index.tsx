import React, { useState } from "react";
import {
  Box,
  Button,
  ButtonText,
  HStack,
  Image,
  Pressable,
  ScrollView,
  Text,
  Textarea,
  TextareaInput,
} from "@gluestack-ui/themed";
import { Header } from "../../components/Header";
import { useForm, Controller } from "react-hook-form";

import saneamentoicon from "../../assets/saneamento.png";
import infraestruturaicon from "../../assets/infraestrutura.png";
import mobilidadeicon from "../../assets/mobilidade.png";
import outrosicon from "../../assets/outros.png";

export const cards = [
  {
    id: 1,
    icon: infraestruturaicon,
    title: "Infraestrutura",
    detail: "Postes com problemas, falta de placas, sinalização da rua. ",
  },
  {
    id: 2,
    icon: saneamentoicon,
    title: "Saneamento",
    detail: "Vazamentos na cidade, problemas com canos, esgoto a céu aberto.",
  },
  {
    id: 3,
    icon: mobilidadeicon,
    title: "Mobilidade",
    detail: "Calçadas quebradas, buracos na rua, falta de acessibilidade.",
  },
  {
    id: 4,
    icon: outrosicon,
    title: "Outros",
    detail:
      "Selecione essa opção se seu problema não se encaixa em nenhuma categoria listada",
  },
];

export function Register() {
  const [problem, setproblem] = useState(1);

  const {
    control,
    handleSubmit,
    formState: { errors },
  } = useForm({
    defaultValues: {},
  });

  const onSubmit = (data: any) => console.log(data);

  return (
    <Box flex={1} bg="$white" h="100%">
      <Header />
      <ScrollView showsVerticalScrollIndicator={false}>
        <Text size="md" p="$4">
          Selecione o tipo de problema:
        </Text>
        <HStack
          gap="$4"
          flex={1}
          flexWrap="wrap"
          alignContent="center"
          justifyContent="center"
        >
          {cards.map((card) => (
            <Controller
              control={control}
              name={"problem" as never}
              key={card.id}
              render={({ field: { onChange, onBlur, value } }) => (
                <Pressable
                  onPress={() => onChange(card.id)}
                  w="$40"
                  borderColor="#6DB8F7"
                  borderWidth={2}
                  borderRadius="$sm"
                  bg="$white"
                  p="$4"
                >
                  <Image
                    source={card.icon}
                    size="xs"
                    alignSelf="center"
                    alt={card.title}
                  />
                  <Text
                    textAlign="center"
                    fontSize="$lg"
                    fontWeight="$bold"
                    mb="$2"
                    color="#0264B7"
                  >
                    {card.title}
                  </Text>
                  <Text textAlign="center" fontSize="$sm" color="#0264B7">
                    {card.detail}
                  </Text>
                </Pressable>
              )}
            />
          ))}
        </HStack>
        <Text size="md" p="$4">
          Descreva o que tem de errado por aí:
        </Text>
        <Box p="$4">
          <Controller
            control={control}
            name={"description" as never}
            render={({ field }) => (
              <Textarea
                alignSelf="center"
                size="md"
                isReadOnly={false}
                isInvalid={false}
                isDisabled={false}
              >
                <TextareaInput placeholder="" {...field} />
              </Textarea>
            )}
          />
        </Box>

        <Button
          m="$4"
          size="md"
          variant="solid"
          action="primary"
          isDisabled={false}
          isFocusVisible={false}
          onPress={handleSubmit(onSubmit)}
        >
          <ButtonText>Finalizar registro</ButtonText>
        </Button>
      </ScrollView>
    </Box>
  );
}
