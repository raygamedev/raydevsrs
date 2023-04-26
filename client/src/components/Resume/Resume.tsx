import { Flex, Grid, createStyles } from '@mantine/core';
import { ResumeCard } from '../ResumeCard/ResumeCard';
import styled from '@emotion/styled';
import { SegmentControl } from '../SegmentControl/SegmentControl';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor: theme.colorScheme === 'dark' ? theme.colors.dark[6] : theme.white,
    boxShadow: theme.shadows.md,
    width: '80%',
    borderRadius: 30,
    padding: 20,
    justifyContent: 'space-around',
    border: `${theme.spacing.xl} solid ${theme.colorScheme === 'dark' ? theme.colors.dark[4] : theme.colors.gray[1]}`,
  },
}));

export const Resume = () => {
  const { classes } = useStyles();
  return (
    <Flex className={classes.root}>
      <SegmentControl />
      <ResumeCard />
    </Flex>
  );
};
