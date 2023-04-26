import { Container, createStyles } from '@mantine/core';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor:
      theme.colorScheme === 'dark' ? theme.colors.dark[6] : theme.white,
    boxShadow: theme.shadows.md,
    width: '80%',
    borderRadius: 30,
    padding: 20,
    justifyContent: 'space-around',
    border: `${theme.spacing.xl} solid ${
      theme.colorScheme === 'dark' ? theme.colors.dark[4] : theme.colors.gray[1]
    }`,
  },
}));
const Summary = () => {
  const { classes } = useStyles();
  return (
    <Container className={classes.root}>
      <h3>Summary</h3>
      <p>
        I am a full-stack software engineer with a passion for building products
        that help people. I have experience working with React, Node.js,
        Express, PostgreSQL, and more. I am a quick learner and love to pick up
        new technologies.
      </p>
    </Container>
  );
};

export default Summary;
