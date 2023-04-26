import { Button, createStyles } from '@mantine/core';

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

const GameButton = () => {
  const { classes } = useStyles();
  return (
    <Button
      className={classes.root}
      variant="gradient"
      gradient={{ from: 'purple', to: 'indigo' }}>
      Try me!
    </Button>
  );
};

export default GameButton;
