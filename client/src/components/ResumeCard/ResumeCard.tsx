import { Card, Image, Text, Badge, Button, Group, createStyles } from '@mantine/core';
import { Colors } from '../../styles/colors';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor: theme.colorScheme === 'dark' ? theme.colors.dark[7] : theme.white,
    borderRadius: 30,
    width: '60%',
  },

  title: {
    color: Colors.LIGHT_PURPLE,
    textAlign: 'left',
    fontWeight: 700,
    fontFamily: `Greycliff CF, ${theme.fontFamily}`,
    lineHeight: 1.2,
  },

  body: {
    padding: theme.spacing.md,
  },
}));

export const ResumeCard = () => {
  const { classes } = useStyles();
  return (
    <Card className={classes.root} shadow="sm" padding="lg" radius={30} withBorder>
      {/* <Card.Section>
        <Image
          src="https://images.unsplash.com/photo-1527004013197-933c4bb611b3?ixid=MnwxMjA3fDB8MHxwaG90by1wYWdlfHx8fGVufDB8fHx8&ixlib=rb-1.2.1&auto=format&fit=crop&w=720&q=80"
          height={160}
          alt="Norway"
        />
      </Card.Section> */}
      <Group position="apart" mt="md" mb="xs">
        <Badge size="lg" color="violet" variant="light">
          Python
        </Badge>
      </Group>
      <Text size="sm" color="dimmed">
        Full-stack development using React.js and Python
      </Text>

      <Group position="left" mt="md" mb="xs">
        <Badge size="lg" color="violet" variant="light">
          React
        </Badge>
        <Badge size="lg" color="violet" variant="light">
          Typescript
        </Badge>
      </Group>
      <Text size="sm" color="dimmed">
        DevOps development on Linux, using Ansible, Docker, GitlabCI, Ubuntu Preseeding, bash scripting
      </Text>

      <Group position="left" mt="md" mb="xs">
        <Badge size="lg" color="violet" variant="light">
          Ansible
        </Badge>
        <Badge size="lg" color="violet" variant="light">
          Docker
        </Badge>
        <Badge size="lg" color="violet" variant="light">
          Gitlab CI
        </Badge>
      </Group>
      <Text size="sm" color="dimmed">
        Responsible for production deployment and developers code machines deployment, including , deciding on tools,
        designing the deployment process{' '}
      </Text>
      <Group position="left" mt="md" mb="xs">
        <Badge size="lg" color="violet" variant="light">
          Bash
        </Badge>
        <Badge size="lg" color="violet" variant="light">
          preseed
        </Badge>
      </Group>
      <Text size="sm" color="dimmed">
        Full responsibility for features, from Design, Development, Testing to Deployment
      </Text>
    </Card>
  );
};
