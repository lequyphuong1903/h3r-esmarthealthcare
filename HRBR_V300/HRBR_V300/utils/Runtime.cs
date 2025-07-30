using Microsoft.ML.OnnxRuntime.Tensors;
using Microsoft.ML.OnnxRuntime;

namespace HRBR_V300.utils
{
    public class Runtime : IDisposable
    {
        private InferenceSession _session;
        public Runtime()
        {
            byte[] onnxModel = Properties.Resources.model_tune1;
            string tempFilePath = Path.GetTempFileName();
            File.WriteAllBytes(tempFilePath, onnxModel);
            _session = new InferenceSession(tempFilePath);
        }

        public float RunInference(float[] inputData, int[] inputDimensions, string inputName = "input")
        {
            var inputTensor = new DenseTensor<float>(inputData, inputDimensions);

            var inputs = new List<NamedOnnxValue>
            {
                NamedOnnxValue.CreateFromTensor(inputName, inputTensor)
            };

            using (var results = _session.Run(inputs))
            {
                var outputTensor = results.First().AsEnumerable<float>().First();
                return outputTensor;
            }
        }

        public void Dispose()
        {
            if (_session != null)
            {
                _session.Dispose();
                _session = null;
            }
        }
    }
}
