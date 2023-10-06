import React, { useEffect, useState } from "react";
import { Box, Button, ButtonText } from "@gluestack-ui/themed";

import {
  LocationObject,
  getCurrentPositionAsync,
  requestForegroundPermissionsAsync,
} from "expo-location";
import MapView, { Marker } from "react-native-maps";
import { View } from "react-native";
import { useNavigation } from "@react-navigation/native";
import { Header } from "../../components/Header";

export function Home() {
  const { navigate } = useNavigation();

  const [location, setLocation] = useState<LocationObject | null>(null);

  async function requestLocationPermissions() {
    const { granted } = await requestForegroundPermissionsAsync();

    if (granted) {
      const currentPosition = await getCurrentPositionAsync();
      setLocation(currentPosition);
    }
  }
  useEffect(() => {
    requestLocationPermissions();
  }, []);

  return (
    <Box flex={1} bg="$white" h="100%">
      <Header />

      {location && (
        <View
          style={{
            flex: 1,
            backgroundColor: "#fff",
            alignItems: "center",
            justifyContent: "center",
            position: "relative",
          }}
        >
          <MapView
            style={{ flex: 1, width: "100%" }}
            initialRegion={{
              latitude: location.coords.latitude,
              longitude: location.coords.longitude,
              latitudeDelta: 0.05,
              longitudeDelta: 0.05,
            }}
          >
            <Marker
              coordinate={{
                latitude: location.coords.latitude,
                longitude: location.coords.longitude,
              }}
            />
          </MapView>

          <Box position="absolute" bottom="$10">
            <Button
              size="md"
              variant="solid"
              action="primary"
              isDisabled={false}
              isFocusVisible={false}
              onPress={() => navigate("Register" as never)}
            >
              <ButtonText>Confirmar localização</ButtonText>
            </Button>
          </Box>
        </View>
      )}
    </Box>
  );
}
