import { MantineProvider, Button, Group, Flex } from '@mantine/core';
import './App.css';
import { TopBar } from './components/TopBar/TopBar';
import styled from '@emotion/styled';
import { Resume } from './components/Resume/Resume';
import { Profile } from './components/Profile/Profile';
import { SegmentControl } from './components/SegmentControl/SegmentControl';

function App() {
  return (
    <Flex direction="column" align="center" gap="md">
      <TopBar
        links={[
          { link: 'cv', label: 'CV' },
          { link: 'github', label: 'GitHub' },
          { link: 'linkedin', label: 'LinkedIn' },
        ]}
      />
      <Profile
        avatar={''}
        name={'Dan Raymond'}
        title={'Fullstack Software Developer'}
        phone={'+972-526865438'}
        email={'dan@raydevs.com'}
      />
      <Resume />
    </Flex>
  );
}

function RayDevs() {
  return (
    <MantineProvider
      withGlobalStyles
      withNormalizeCSS
      theme={{
        spacing: {
          xl: '100',
        },
        colorScheme: 'dark',
        fontFamily: 'JetbrainsMonoLight',
      }}
    >
      <App />
    </MantineProvider>
  );
}

export default RayDevs;
