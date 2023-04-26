import { createStyles, Card, Image, Avatar, Text, Group } from '@mantine/core';
import { Colors } from '../../styles/colors';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor: theme.colorScheme === 'dark' ? theme.colors.dark[7] : theme.white,
    borderRadius: 30,
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

interface SegmentItemProps {
  title: string;
  startDate: string;
  endDate: string;
  company: {
    name: string;
    avatar: string;
  };
}

export function SegmentItem({ title, startDate, endDate, company }: SegmentItemProps) {
  const { classes } = useStyles();
  return (
    <Card withBorder radius="md" p={0} className={classes.root}>
      <Group noWrap spacing={0}>
        <div className={classes.body}>
          <Text className={classes.title} mt="xs" mb="xs">
            {title}
          </Text>
          <Group mb="xs" noWrap spacing="xs">
            <Text size="xs" color="dimmed">
              •
            </Text>
            <Text align="left" size="xs" color="dimmed">
              {startDate} - {endDate}
            </Text>
          </Group>
          <Group spacing="xs" noWrap>
            <Avatar size={30} src={company.avatar} />
            <Text size={17}>{company.name}</Text>
          </Group>
        </div>
      </Group>
    </Card>
  );
}
