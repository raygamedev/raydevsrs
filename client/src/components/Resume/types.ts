interface Company {
  name: string;
  avatar: string;
}

export interface SegmentItemData {
  title: string;
  startDate: string;
  endDate: string;
  company: Company;
}

export interface SegmentDescriptionData {
  badge: string | string[];
  text: string | string[];
}

export enum ResumeKeys {
  SoftwareDeveloper = 'SoftwareDeveloper',
  QaAutomation = 'QaAutomation',
  DataTeamMember = 'DataTeamMember',
}

export type ResumeData = {
  [key in ResumeKeys]: {
    segmentItem: SegmentItemData;
    segmentDescription: SegmentDescriptionData[];
  };
};
