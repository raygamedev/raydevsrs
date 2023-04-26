import { Flex, Grid, createStyles, SegmentedControlItem } from '@mantine/core';
import { ResumeCard, ResumeCardProps } from './ResumeCard';
import styled from '@emotion/styled';
import { SegmentControl } from './SegmentControl';
import { SegmentItem } from './SegmentItem';
import InspektoLogo from '../../art/InspektoLogo.png';
import { useState } from 'react';
import { ResumeCardType } from './enums';

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
type ResumeData = {
  [key in ResumeCardType]: ResumeCardProps[];
};
const resumeData: ResumeData = {
  [ResumeCardType.SoftwareDeveloper]: [
    { badge: ['Python', 'React'], text: 'test' },
    { badge: 'Python', text: 'test' },
  ],
  [ResumeCardType.QaAutomation]: [],
  [ResumeCardType.DataTeamMember]: [],
};

export const Resume = () => {
  const { classes } = useStyles();
  const [active, setActive] = useState<ResumeCardType>(
    ResumeCardType.SoftwareDeveloper,
  );

  const SegmentItems: SegmentedControlItem[] = [
    {
      label: SegmentItem({
        title: 'Software Developer',
        startDate: 'Apr 2020',
        endDate: 'Current',
        company: { name: 'Inspekto', avatar: InspektoLogo },
      }),
      value: ResumeCardType.SoftwareDeveloper,
    },
    {
      label: SegmentItem({
        title: 'QA Automation',
        startDate: 'Apr 2019',
        endDate: 'Apr 2020',
        company: { name: 'Inspekto', avatar: InspektoLogo },
      }),
      value: ResumeCardType.QaAutomation,
    },
    {
      label: SegmentItem({
        title: 'Data Team Member',
        startDate: 'May 2018',
        endDate: 'Apr 2019',
        company: { name: 'Inspekto', avatar: InspektoLogo },
      }),
      value: ResumeCardType.DataTeamMember,
    },
  ];

  return (
    <Flex className={classes.root}>
      <SegmentControl setActive={setActive} segmentItems={SegmentItems} />
      <ResumeCard data={resumeData[active]} />
    </Flex>
  );
};
