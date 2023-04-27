import { createStyles, Avatar, Text, Group } from '@mantine/core';
import { IconPhoneCall, IconAt } from '@tabler/icons-react';
import ProfilePicture from '../../art/profiePicture.png';
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

interface ProfileType {
  avatar: string;
  name: string;
  title: string;
  phone: string;
  email: string;
}
const ProfileData: ProfileType = {
  avatar: ProfilePicture,
  name: 'Dan Raymond',
  title: 'Fullstack Software Developer',
  phone: '+972-526865438',
  email: 'dan@raydevs.com',
};
// TODO: Make phone and email copyable
export function Profile() {
  const { avatar, name, title, phone, email } = ProfileData;
  const { classes } = useStyles();
  return (
    <Group
      style={{
        display: 'flex',
        justifyContent: 'center',
      }}>
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
