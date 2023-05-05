FROM unityci/editor:2021.3.24f1-webgl-1
# Copy the project files into the container
COPY . /project

# Set the working directory
WORKDIR /project

# Log in to Unity
#ARG UNITY_USERNAME
#ARG UNITY_PASSWORD
#RUN [ -z "$UNITY_USERNAME" ] && echo "Unity username not set" && exit 1 || echo "Using Unity username: $UNITY_USERNAME"
#RUN [ -z "$UNITY_PASSWORD" ] && echo "Unity password not set" && exit 1 || echo "Using Unity password: $UNITY_PASSWORD"
#RUN unity-hub login -u "$UNITY_USERNAME" -p "$UNITY_PASSWORD"

# Build the WebGL project
#RUN unity-hub build --targetPlatform WebGL --buildPath /build
#
## Expose the build output directory
#VOLUME /build
