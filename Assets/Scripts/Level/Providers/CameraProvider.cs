using UnityEngine;

namespace Level.Providers
{
    public sealed class CameraProvider : ICameraProvider
    {
        private Camera _camera;

        public Camera Camera => _camera;

        public CameraProvider(Camera camera)
        {
            _camera = camera;
        }
    }
}