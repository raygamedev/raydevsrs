import { MantineProvider, Flex, createStyles, Group } from '@mantine/core';
import './App.css';
import { TopBar } from './components/TopBar/TopBar';
import { Resume } from './components/Resume/Resume';
import { Profile } from './components/Profile/Profile';
import Summary from './components/Summary/Summary';
import GameButton from './components/GameButton/GameButton';
import ProfilePicture from './art/profiePicture.png';
const useStyles = createStyles(() => ({
  root: {
    display: 'flex',
    flexDirection: 'column',
    alignItems: 'center',
    gap: 20,
  },
  profileGame: {
    width: '80%',
    justifyContent: 'space-between',
    alignItems: 'center',
  },
  summaryContainer: {
    display: 'flex',
    flexDirection: 'row',
    width: '80%',
  },
}));

function App() {
  const { classes } = useStyles();
  return (
    <Flex className={classes.root}>
      <TopBar />
      <Flex className={classes.profileGame}>
        <Profile
          avatar={ProfilePicture}
          name={'Dan Raymond'}
          title={'Fullstack Software Developer'}
          phone={'+972-526865438'}
          email={'dan@raydevs.com'}
        />
        {/* <GameButton /> */}
      </Flex>
      <Summary />
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
      }}>
      <App />
    </MantineProvider>
  );
}

export default RayDevs;
