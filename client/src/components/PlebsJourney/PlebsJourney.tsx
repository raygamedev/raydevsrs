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
    loaderUrl: 'build/build.loader.js',
    dataUrl: 'build/build.data',
    frameworkUrl: 'build/build.framework.js',
    codeUrl: 'build/build.wasm',
  });
  return <div></div>;
};
