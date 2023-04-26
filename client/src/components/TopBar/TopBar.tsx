import {
  Text,
  createStyles,
  Header,
  Container,
  Group,
  rem,
  Button,
} from '@mantine/core';
import {
  IconBrandGithub,
  IconBrandLinkedin,
  IconFileDescription,
} from '@tabler/icons-react';

const HEADER_HEIGHT = rem(60);

const useStyles = createStyles((theme) => ({
  root: {
    width: '100%',
    position: 'relative',
    zIndex: 1,
  },

  header: {
    display: 'flex',
    justifyContent: 'space-between',
    alignItems: 'center',
    height: '100%',
  },
  title: {
    fontFamily: 'Retro',
    fontSize: rem(20),
    color: theme.colorScheme == 'dark' ? theme.white : theme.colors.dark[7],
  },
}));

export function TopBar() {
  const { classes } = useStyles();

  return (
    <Header height={HEADER_HEIGHT} className={classes.root}>
      <Container className={classes.header}>
        <Text className={classes.title}>Raydevs</Text>
        <Group>
          {/* <Button
            component="a"
            target="_blank"
            rel="noopener noreferrer"
            href="https://github.com/raygamedev"
            color="violet"
            leftIcon={<IconFileDescription size={rem(20)} />}>
            CV
          </Button> */}
          <Button
            component="a"
            target="_blank"
            rel="noopener noreferrer"
            href="https://github.com/raygamedev"
            color="gray"
            leftIcon={<IconBrandGithub size={rem(20)} />}>
            GitHub
          </Button>
          <Button
            component="a"
            target="_blank"
            rel="noopener noreferrer"
            href="https://www.linkedin.com/in/ray-dev/"
            color="gray"
            leftIcon={<IconBrandLinkedin size={rem(20)} />}>
            Linkedin
          </Button>
        </Group>
      </Container>
    </Header>
  );
}
