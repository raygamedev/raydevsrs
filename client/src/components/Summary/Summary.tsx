import { Text, Container, Group, createStyles } from '@mantine/core';

const useStyles = createStyles((theme) => ({
  container: {
    backgroundColor:
      theme.colorScheme === 'dark' ? theme.colors.dark[6] : theme.white,
    boxShadow: theme.shadows.md,
    borderRadius: 30,
    padding: 20,
    justifyContent: 'space-around',
    border: `${theme.spacing.xl} solid ${
      theme.colorScheme === 'dark' ? theme.colors.dark[4] : theme.colors.gray[1]
    }`,
  },
}));
interface SummaryBlock {
  title: string;
  text: string[];
}
const SummaryBlocks: SummaryBlock[] = [
  {
    title: 'Summary',
    text: [
      'Level 5 Linux Master and Level 4 Full-Stack Developer skilled in Python, React, Typescript. Adept at leveling up skills independently and grinding knowledge in technology and software development. With a remarkable ability to maintain focus during epic quests, they unleash their creativity in video game development and harness the power of the Rust language.',
    ],
  },
  {
    title: 'Strong Attributes',
    text: [
      'Experienced Adventurer: 5 years in Linux and 4 years in full-stack development using Python, NodeJS, and ReactJS.',
      'Skill Master: Rapidly learning and applying new skills solo.',
      'Tech Connoisseur: Immersed in the realm of technology, computers, and software development.',
      'Focused Tactician: Sustaining concentration for marathon missions, boosting productivity.',
    ],
  },
  {
    title: 'Weak Attributes',
    text: [
      'IDE OCD: Obsessing over organizing IDE settings and computer configurations, which can sometimes distract from more crucial missions.',
      'Emotional Encounter: Being overly emotional in certain situations, making it challenging to maintain balance during workplace quests.',
    ],
  },
];

const Summary = () => {
  const { classes } = useStyles();
  return (
    <Group>
      {SummaryBlocks.map((block) => {
        return (
          <Container className={classes.container} key={block.title} size="xs">
            <Text>{block.title}</Text>
            {block.text.map((text, index) => {
              return (
                <Group noWrap key={index} position="left">
                  <Text>•</Text>
                  <Text size="sm" color="dimmed">
                    {text}
                  </Text>
                </Group>
              );
            })}
          </Container>
        );
      })}
    </Group>
  );
};

export default Summary;
