import { createStyles, SegmentedControl, rem, SegmentedControlItem } from '@mantine/core';
import { Colors } from '../../styles/colors';
import { ResumeCard } from '../ResumeCard/ResumeCard';
import { ReactNode } from 'react';
import { SegmentItem } from './SegmentItem';
import InspektoLogo from '../../art/InspektoLogo.png';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor: theme.colorScheme === 'dark' ? theme.colors.dark[6] : theme.white,
  },

  //   indicator: {
  //     backgroundImage: theme.fn.gradient({ from: 'gray', to: 'gray' }),
  //   },

  control: {
    border: '0 !important',
  },

  label: {
    color: `${Colors.MAUVE}`,
    '&, &:hover': {
      '&[data-active]': {
        color: Colors.LIGHT_PURPLE,
      },
    },
  },
}));

export const SegmentControl = () => {
  const SegmentItems: SegmentedControlItem[] = [
    {
      label: SegmentItem({
        title: 'Software Developer',
        startDate: 'Apr 2020',
        endDate: 'Current',
        company: { name: 'Inspekto', avatar: InspektoLogo },
      }),
      value: 'y',
    },
    {
      label: SegmentItem({
        title: 'QA Automation',
        startDate: 'Apr 2019',
        endDate: 'Apr 2020',
        company: { name: 'Inspekto', avatar: InspektoLogo },
      }),
      value: 'x',
    },
    {
      label: SegmentItem({
        title: 'Data Team Member',
        startDate: 'May 2018',
        endDate: 'Apr 2019',
        company: { name: 'Inspekto', avatar: InspektoLogo },
      }),
      value: 'all',
    },
  ];
  const { classes } = useStyles();
  return <SegmentedControl orientation="vertical" radius="xl" size="md" data={SegmentItems} classNames={classes} />;
};
// Software Developer
// INSPEKTO
// Apr 2020 - Present (3 years)
// • Full-stack development using React.js and Python
// • DevOps development on Linux, using Ansible, Docker, GitlabCI, Ubuntu Preseeding, bash scripting • Responsible for production deployment and developers code machines deployment, including , deciding on tools, designing the deployment process
// • Full responsibility for features, from Design, Development, Testing to Deployment
// QA Automation
// INSPEKTO
// Apr 2019 - Apr 2020 (1 year 1 month)
// • UI Automation using Node.js
// • Development of Automation framework using Python
// • Development of CI\CD pipelines using Jenkins and Python
// • Responsible for deciding on infrastructure, development tools, and leading an undergraduate employee
// • Responsible for automating our production build process and Automated CI\CD testing from scratch.
// Data Team Member
// INSPEKTO
// May 2018 - Apr 2019 (1 year)
// • Linux Basics
// • Data analysis for Algo team,creating visualizations and analyzing it, using heatmaps, csv files, and basic Python scripting for automating tools
