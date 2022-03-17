using System.Collections;
using System.Collections.Generic;
using UnityEngine;

/// <summary>
/// Provides access to configuration data
/// </summary>
public static class ConfigurationUtils
{
    static ConfigurationData configurationData;

    #region Properties

    /// <summary>
    /// Gets the balls per game
    /// </summary>
    /// <value>balls per game</value>
    public static int BallsPerGame
    {
        get { return configurationData.BallsPerGame; }
    }

    /// <summary>
    /// Gets the ball lifetime in second
    /// </summary>
    /// <value>ball lifetime in second</value>
    public static int MaxSpawnSeconds
    {
        get { return configurationData.MaxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the ball lifetime in second
    /// </summary>
    /// <value>ball lifetime in second</value>
    public static int MinSpawnSeconds
    {
        get { return configurationData.MinSpawnSeconds; }
    }

    /// <summary>
    /// Gets the ball lifetime in second
    /// </summary>
    /// <value>ball lifetime in second</value>
    public static float BallLifetime
    {
        get { return configurationData.BallLifetime; }
    }

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float PaddleMoveUnitsPerSecond
    {
        get { return configurationData.PaddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the ball impulse units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public static float BallImpulseForce
    {
        get { return configurationData.BallImpulseForce; }
    }

    #endregion

    /// <summary>
    /// Initializes the configuration utils
    /// </summary>
    public static void Initialize()
    {
        configurationData = new ConfigurationData();

    }
}
