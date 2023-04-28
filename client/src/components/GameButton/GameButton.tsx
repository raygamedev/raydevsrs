import { Button, Modal, createStyles, Text, Group, Flex } from '@mantine/core';
import { useMediaQuery } from '@mantine/hooks';
import {
  IconBrandGithub,
  IconPlayerPause,
  IconPlayerPlay,
} from '@tabler/icons-react';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor:
      theme.colorScheme === 'dark' ? theme.colors.dark[6] : theme.white,
    boxShadow: theme.shadows.md,
    width: 300,
    height: 100,
    fontSize: 37,
    borderRadius: 10,
    justifyContent: 'space-around',
    fontFamily: 'Retro',
    border: `${theme.spacing.xl} solid ${
      theme.colorScheme === 'dark' ? theme.colors.dark[4] : theme.colors.gray[1]
    }`,
  },
  text: {
    color: theme.colorScheme == 'dark' ? theme.white : theme.colors.dark[7],
    alignContent: 'center',
    justifyContent: 'center',
    alignItems: 'center',
    textAlign: 'center',
    width: '60%',
  },
}));
interface GameButtonProps {
  isPlaying: boolean;
  onClick: (value: boolean) => void;
}
const GameButton = ({ isPlaying, onClick }: GameButtonProps) => {
  const isMobile = useMediaQuery('(max-width: 50em)');

  const { classes } = useStyles();
  const buttonStyle =
    isPlaying && !isMobile
      ? {
          icon: <IconPlayerPause size={50} />,
          gradient: { from: 'red', to: 'purple' },
          text: 'pause',
        }
      : {
          icon: <IconPlayerPlay stroke={4} size={50} />,
          gradient: { from: 'purple', to: 'indigo' },
          text: 'try me',
        };
  return (
    <>
      <Modal
        radius={15}
        opened={isPlaying && isMobile}
        onClose={() => onClick(!isPlaying)}>
        <Flex
          justify="space-between"
          direction="column"
          align="center"
          gap={20}
          mb="xl"
          mt="xl">
          <Text className={classes.text}>
            {"Pleb's Journey isnt available on Mobile yet"}
          </Text>
          <Text size="sm" color="dimmed">
            Please open in a desktop browser
          </Text>
          <Button color="violet" onClick={() => onClick(!isPlaying)}>
            Close
          </Button>
        </Flex>
      </Modal>
      <Button
        disabled={isPlaying && isMobile}
        onClick={() => onClick(!isPlaying)}
        className={classes.root}
        variant="gradient"
        rightIcon={buttonStyle.icon}
        gradient={buttonStyle.gradient}>
        {buttonStyle.text}
      </Button>
    </>
  );
};

export default GameButton;
