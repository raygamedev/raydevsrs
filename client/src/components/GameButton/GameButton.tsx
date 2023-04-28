import { Button, createStyles } from '@mantine/core';
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
}));
interface GameButtonProps {
  isPlaying: boolean;
  onClick: (value: boolean) => void;
}
const GameButton = ({ isPlaying, onClick }: GameButtonProps) => {
  const { classes } = useStyles();
  const buttonStyle = isPlaying
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
    <Button
      onClick={() => onClick(!isPlaying)}
      className={classes.root}
      variant="gradient"
      rightIcon={buttonStyle.icon}
      gradient={buttonStyle.gradient}>
      {buttonStyle.text}
    </Button>
  );
};

export default GameButton;
