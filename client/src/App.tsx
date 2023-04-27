import { MantineProvider, Flex, createStyles, Group } from '@mantine/core';
import './fonts/Fonts.css';
import { TopBar } from './components/TopBar/TopBar';
import { Resume } from './components/Resume/Resume';
import { Profile } from './components/Profile/Profile';
import Summary from './components/Summary/Summary';
import GameButton from './components/GameButton/GameButton';
import useIsMobile from './hooks/useIsMobile';
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
    flexDirection: 'row',
    flexWrap: 'wrap',
  },
  summaryContainer: {
    display: 'flex',
    flexDirection: 'row',
    width: '80%',
  },
}));
const App = () => {
  const isMobile = useIsMobile();
  const { classes } = useStyles();
  return (
    <Flex className={classes.root}>
      <TopBar isMobile={isMobile} />
      <Flex className={classes.profileGame}>
        <Profile />
        <GameButton />
      </Flex>
      <Summary />
      <Resume />
    </Flex>
  );
};

const RayDevs = () => {
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
};

export default RayDevs;
