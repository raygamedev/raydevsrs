import { Card, Text, Badge, Group, createStyles } from '@mantine/core';
import { Colors } from '../../styles/colors';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor:
      theme.colorScheme === 'dark' ? theme.colors.dark[7] : theme.white,
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

export interface ResumeCardProps {
  badge: string | string[];
  text: string;
}

export const ResumeCard = ({ data }: { data: ResumeCardProps[] }) => {
  const { classes } = useStyles();
  return (
    <Card
      className={classes.root}
      shadow="sm"
      padding="lg"
      radius={30}
      withBorder>
      {data.map((item) => (
        <>
          <Group position="left" mt="md" mb="xs">
            {Array.isArray(item.badge) ? (
              item.badge.map((badge) => (
                <Badge key={badge} size="lg" color="violet" variant="light">
                  {badge}
                </Badge>
              ))
            ) : (
              <Badge size="lg" color="violet" variant="light">
                {item.badge}
              </Badge>
            )}
          </Group>
          <Text size="sm" color="dimmed">
            {item.text}
          </Text>
        </>
      ))}
    </Card>
  );
};
