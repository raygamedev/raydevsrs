import styled from '@emotion/styled';
import { Unity, useUnityContext } from 'react-unity-webgl';

const ResumeModal = styled.div`
  background: #3f3f44;
  width: 60%;
  height: 60%;
  border-radius: 15px;
  align-items: center;
  display: flex;
  justify-content: center;
  font-family: RetroComputer, serif;
`;
export const PlebsJourney = (): JSX.Element => {
  const { unityProvider } = useUnityContext({
    loaderUrl: 'build/test.loader.js',
    dataUrl: 'build/test.data',
    frameworkUrl: 'build/test.framework.js',
    codeUrl: 'build/test.wasm',
  });
  return <div></div>;
};
