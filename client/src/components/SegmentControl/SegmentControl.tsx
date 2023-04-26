import {
  createStyles,
  SegmentedControl,
  SegmentedControlItem,
} from '@mantine/core';
import { Colors } from '../../styles/colors';
import { SegmentItem } from './SegmentItem';
import InspektoLogo from '../../art/InspektoLogo.png';

const useStyles = createStyles((theme) => ({
  root: {
    backgroundColor:
      theme.colorScheme === 'dark' ? theme.colors.dark[6] : theme.white,
  },

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
  return (
    <SegmentedControl
      orientation="vertical"
      radius="xl"
      size="md"
      data={SegmentItems}
      classNames={classes}
    />
  );
};
