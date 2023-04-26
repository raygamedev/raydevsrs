import { Flex, createStyles, SegmentedControlItem } from '@mantine/core';
import { SegmentControl } from './SegmentControl';
import { SegmentItem } from './SegmentItem';
import InspektoLogo from '../../art/InspektoLogo.png';
import { useState } from 'react';
import { ResumeCardType } from './enums';
import { ResumeData, ResumeKeys } from './types';
import { SegmentDescription } from './SegmentDescription';

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

const resumeData: ResumeData = {
  [ResumeKeys.SoftwareDeveloper]: {
    segmentItem: {
      title: 'Software Developer',
      startDate: 'April 2020',
      endDate: 'Current',
      company: {
        name: 'Inspekto',
        avatar: InspektoLogo,
      },
    },
    segmentDescription: [
      {
        badge: ['React', 'TypeScript', 'Python', 'Flask', 'FastAPI', 'MongoDB'],
        text: [
          'Full-stack development using Python, React, TypeScript, MongoDB resulting in a highly responsive and user-friendly application.',
          'Full responsibility for features, from design, development, testing to deployment for both frontend and backend.',
        ],
      },
      {
        badge: ['Docker', 'Gitlab CI/CD'],
        text: 'Implemented DevOps CI/CD practices on Linux, Docker, GitlabCI',
      },
      {
        badge: ['Ansible', 'Python', 'Bash', 'Preseed', 'Linux'],
        text: [
          'Responsible for the deployment of the product on Linux on-prem machines, including deciding on tools and designing the deployment process.',
          'Created a new deployment process for our product from scratch using Ansible, Python, Bash, and Preseed for automating boot installtion.',
          'Streamlined the deployment pipeline by implementing automated scripts and configuration management tools.',
          'Created a new deployment process for our dev machines using Ansible, Python, Bash, and Preseed for automating installtion.',
          'Significantly reduced deployment times and human errors for both dev and prod environments.',
        ],
      },
    ],
  },
  [ResumeKeys.QaAutomation]: {
    segmentItem: {
      title: 'QA Automation',
      startDate: 'April 2019',
      endDate: 'April 2020',
      company: {
        name: 'Inspekto',
        avatar: InspektoLogo,
      },
    },
    segmentDescription: [
      {
        badge: ['Node.JS', 'Puppeteer'],
        text: 'Development UI Automation using NodeJS and Puppeteer',
      },
      {
        badge: 'python',
        text: 'Development of Automation framework using Python from scratch',
      },
      {
        badge: ['Jenkins', 'Python'],
        text: 'Development of CI/CD pipeline using Jenkins and Python',
      },
      {
        badge: 'Misc',
        text: [
          'Responsible for deciding on infastructure and tools for automation',
          "During this period I've studied and learned about automation, CI/CD, DevOps, and Software Development in my free time and I've been able to apply this knowledge to my work",
        ],
      },
    ],
  },
  [ResumeKeys.DataTeamMember]: {
    segmentItem: {
      title: 'Data Team Member',
      startDate: 'May 2018',
      endDate: 'April 2019',
      company: {
        name: 'Inspekto',
        avatar: InspektoLogo,
      },
    },
    segmentDescription: [
      {
        badge: 'Python',
        text: [
          'Developed automated tools to improve efficiency and accuracy in data analysis processes.',
          'Conducted data analysis for the Algorithm team, creating visualizations and analyzing data using heatmaps, CSV files, and basic Python scripting.',
        ],
      },
      {
        badge: 'Git',
        text: [
          'Learned Git fundamentals, enabling a better understanding of the development environment, and for testing ML models.',
        ],
      },
      {
        badge: 'Linux',
        text: [
          'Acquired Linux fundamentals, enabling a better understanding of the development environment',
        ],
      },
    ],
  },
};

export const Resume = () => {
  const { classes } = useStyles();
  const [active, setActive] = useState<ResumeCardType>(
    ResumeCardType.SoftwareDeveloper,
  );

  const extractSegmentItems = (
    resumeData: ResumeData,
  ): SegmentedControlItem[] => {
    const segmentedItems: SegmentedControlItem[] = [];
    for (const key in resumeData) {
      const segment: SegmentedControlItem = {
        label: (
          <SegmentItem
            segmentData={resumeData[key as ResumeCardType].segmentItem}
          />
        ),
        value: key as ResumeCardType,
      };
      segmentedItems.push(segment);
    }
    return segmentedItems;
  };

  return (
    <Flex className={classes.root}>
      <SegmentControl
        setActive={setActive}
        segmentItems={extractSegmentItems(resumeData)}
      />
      <SegmentDescription
        segmentDescriptionList={resumeData[active].segmentDescription}
      />
    </Flex>
  );
};
