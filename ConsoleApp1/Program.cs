using Stride.Core.Mathematics;
using Stride.Engine;
using Stride.GameDefaults.ProceduralModels;
using Stride.GameDefaults.Extensions;

using (var game = new Game())
{
    game.Run(start: Start);

    void Start(Scene rootScene)
    {
        game.SetupBase3DScene();

        var entity = game.CreatePrimitive(PrimitiveModelType.Capsule);

        entity.Transform.Position = new Vector3(0, 9, 0);
        entity.Scene = rootScene;
    }
}