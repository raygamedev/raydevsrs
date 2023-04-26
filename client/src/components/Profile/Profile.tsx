import { createStyles, Avatar, Text, Group } from '@mantine/core';
import { IconPhoneCall, IconAt } from '@tabler/icons-react';

const useStyles = createStyles((theme) => ({
  root: {
    width: '80%',
  },
  icon: {
    color:
      theme.colorScheme === 'dark'
        ? theme.colors.dark[3]
        : theme.colors.gray[5],
  },

  name: {
    fontFamily: `Greycliff CF, ${theme.fontFamily}`,
  },
}));

interface ProfileProps {
  avatar: string;
  name: string;
  title: string;
  phone: string;
  email: string;
}

export function Profile({ avatar, name, title, phone, email }: ProfileProps) {
  const { classes } = useStyles();
  return (
    <Group noWrap>
      <Avatar src={avatar} size={200} radius="md" />
      <div>
        <Text fz="xs" tt="uppercase" fw={700} c="dimmed">
          {title}
        </Text>

        <Text fz="lg" fw={500} className={classes.name}>
          {name}
        </Text>

        <Group noWrap spacing={10} mt={3}>
          <IconAt stroke={1.5} size="1rem" className={classes.icon} />
          <Text fz="xs" c="dimmed">
            {email}
          </Text>
        </Group>

        <Group noWrap spacing={10} mt={5}>
          <IconPhoneCall stroke={1.5} size="1rem" className={classes.icon} />
          <Text fz="xs" c="dimmed">
            {phone}
          </Text>
        </Group>
      </div>
    </Group>
  );
}
