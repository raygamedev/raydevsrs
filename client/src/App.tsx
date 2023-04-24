import React from 'react';
import { MantineProvider, Button } from '@mantine/core';
import './App.css';
import { TopBar } from './components/TopBar/TopBar';
import { Fonts } from './fonts';

function App() {
  return <TopBar />;
}

function RayDevs() {
  return (
    <MantineProvider
      theme={{
        colorScheme: 'light',
        fontFamily: 'Retro',
      }}
    >
      <Fonts />
      <App />
    </MantineProvider>
  );
}

export default RayDevs;
