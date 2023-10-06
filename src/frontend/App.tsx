import { Box, GluestackUIProvider, StatusBar } from "@gluestack-ui/themed";

import { AppNav } from "./src/navigation";

export default function App() {
  return (
    <GluestackUIProvider>
      <StatusBar />
      <Box height="100%">
        <AppNav />
      </Box>
    </GluestackUIProvider>
  );
}
