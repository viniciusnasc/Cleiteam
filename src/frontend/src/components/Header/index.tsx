import { Avatar, AvatarFallbackText, HStack, Text } from "@gluestack-ui/themed";

export function Header() {
  return (
    <HStack h="$16" bg="$info600" alignItems="center" p="$1">
      <HStack alignItems="center">
        <Avatar bgColor="$white" size="sm" borderRadius="$full" m="$2">
          <AvatarFallbackText color="$black">Jandira Silva</AvatarFallbackText>
        </Avatar>
        <Text color="$white">Olá, Jandira!</Text>
      </HStack>
    </HStack>
  );
}
