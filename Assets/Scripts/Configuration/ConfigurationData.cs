using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System;

/// <summary>
/// A container for the configuration data
/// </summary>
public class ConfigurationData
{
    #region Fields

    const string ConfigurationDataFileName = "ConfigurationData.csv";

    // configuration data
    static float ballLifetime = 10;
    static float paddleMoveUnitsPerSecond = 10;
    static float ballImpulseForce = 200;
    static int maxSpawnSeconds = 10;
    static int minSpawnSeconds = 3;
    static int ballsPerGame = 5;
    #endregion

    #region Properties

    /// <summary>
    /// Gets the ball lifetime in seconds
    /// </summary>
    /// <value>ball lifetime in second</value>
    public int BallsPerGame
    {
        get { return ballsPerGame; }
    }

    /// <summary>
    /// Gets the ball lifetime in seconds
    /// </summary>
    /// <value>ball lifetime in second</value>
    public int MaxSpawnSeconds
    {
        get { return maxSpawnSeconds; }
    }

    /// <summary>
    /// Gets the ball lifetime in seconds
    /// </summary>
    /// <value>ball lifetime in second</value>
    public int MinSpawnSeconds
    {
        get { return minSpawnSeconds; }
    }

    /// <summary>
    /// Gets the ball lifetime in seconds
    /// </summary>
    /// <value>ball lifetime in second</value>
    public float BallLifetime
    {
        get { return ballLifetime; }
    }

    /// <summary>
    /// Gets the paddle move units per second
    /// </summary>
    /// <value>paddle move units per second</value>
    public float PaddleMoveUnitsPerSecond
    {
        get { return paddleMoveUnitsPerSecond; }
    }

    /// <summary>
    /// Gets the impulse force to apply to move the ball
    /// </summary>
    /// <value>impulse force</value>
    public float BallImpulseForce
    {
        get { return ballImpulseForce; }    
    }

    #endregion

    #region Constructor


    /// <summary>
    /// Constructor
    /// Reads configuration data from a file. If the file
    /// read fails, the object contains default values for
    /// the configuration data
    /// </summary>
    public ConfigurationData()
    {
        // read and save configuration data from file
        StreamReader input = null;
        try
        {
            // create stream reader object
            input = File.OpenText(Path.Combine(
                Application.streamingAssetsPath, ConfigurationDataFileName));

            // read in names and values
            string names = input.ReadLine();
            string values = input.ReadLine();

            // set configuration data fields
            SetConfigurationDataFields(values);
        }
        catch (Exception e)
        {
        }
        finally
        {
            // always close input file
            if (input != null)
            {
                input.Close();
            }
        }
    }


    /// <summary>
    /// Sets the configuration data fields from the provided
    /// csv string
    /// </summary>
    /// <param name="csvValues">csv string of values</param>
    void SetConfigurationDataFields(string csvValues)
    {
        // the code below assumes we know the order in which the
        // values appear in the string. We could do something more
        // complicated with the names and values, but that's not
        // necessary here
        string[] values = csvValues.Split(';');
        paddleMoveUnitsPerSecond = float.Parse(values[0]);
        ballImpulseForce = float.Parse(values[1]);
        ballLifetime = float.Parse(values[2]);
        minSpawnSeconds = int.Parse(values[3]);
        maxSpawnSeconds = int.Parse(values[4]);
        ballsPerGame = int.Parse(values[5]);
    }

    #endregion
}
