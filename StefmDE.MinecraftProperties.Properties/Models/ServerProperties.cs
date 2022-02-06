using System.Reflection;
using System.Text;
using StefmDE.MinecraftProperties.Properties.Attributes;
// ReSharper disable UnusedMember.Global

namespace StefmDE.MinecraftProperties.Properties.Models;

// https://minecraft.fandom.com/wiki/Server.properties
public class ServerProperties
{
    public ServerProperties()
    {
        LoadDefaults();
    }
    
    [PropertyInfo("allow-flight", false)]
    [PropertyDescription("Allows users to use flight on the server while in Survival mode, if they have a mod that provides flight installed. With allow-flight enabled, griefers may become more common, because it makes their work easier. In Creative mode, this has no effect. 'false' - Flight is not allowed (players in air for at least 5 seconds get kicked). 'true' - Flight is allowed, and used if the player has a fly mod installed.")]
    public PropertyWrapper<bool>? AllowFlight { get; set; }
    
    [PropertyInfo("allow-nether", true, "1.6")]
    [PropertyDescriptionAttribute("Allows players to travel to the Nether. 'false' - Nether portals do not work. 'true' - The server allows portals to send players to the Nether.")]
    public PropertyWrapper<bool>? AllowNether { get; set; }
    
    [PropertyInfo("broadcast-console-to-ops", true)]
    [PropertyDescriptionAttribute("Send console command outputs to all online operators.")]
    public PropertyWrapper<bool>? BroadcastConsoleToOps { get; set; }

    [PropertyInfo("broadcast-rcon-to-ops", true)]
    [PropertyDescriptionAttribute("Send rcon console command outputs to all online operators.")]
    public PropertyWrapper<bool>? BroadcastRconToOps { get; set; }

    [PropertyInfo("difficulty", "easy", "1.14")]
    [PropertyDescriptionAttribute("Defines the difficulty (such as damage dealt by mobs and the way hunger and poison affects players) of the server. If a legacy difficulty number is specified, it is silently converted to a difficulty name. peaceful (0), easy (1), normal (2), hard (3)")]
    public PropertyWrapper<string>? Difficulty { get; set; }

    [PropertyInfo("enable-command-block", false)]
    [PropertyDescriptionAttribute("Enables command blocks")]
    public PropertyWrapper<bool>? EnableCommandBlock { get; set; }

    [PropertyInfo("enable-jmx-monitoring", false, "1.16")]
    [PropertyDescriptionAttribute("Exposes an MBean with the Object name net.minecraft.server:type=Server and two attributes averageTickTime and tickTimes exposing the tick times in milliseconds. In order for enabling JMX on the Java runtime you also need to add a couple of JVM flags to the startup as documented here.")]
    public PropertyWrapper<bool>? EnableJmxMonitoring { get; set; }

    [PropertyInfo("enable-rcon", false, "1.0.0")]
    [PropertyDescriptionAttribute("Enables remote access to the server console. It's not recommended to expose RCON to the Internet, because RCON protocol transfers everything without encryption. Everything (including RCON password) communicated between the RCON server and client can be leaked to someone listening in on your connection.")]
    public PropertyWrapper<bool>? EnableRcon { get; set; }

    [PropertyInfo("sync-chunk-writes", true, "1.16")]
    [PropertyDescriptionAttribute("Enables synchronous chunk writes.")]
    public PropertyWrapper<bool>? SyncChunkWrites { get; set; }

    [PropertyInfo("enable-status", true, "1.16")]
    [PropertyDescriptionAttribute("Makes the server appear as 'online' on the server list. If set to false, it will suppress replies from clients. This means it will appear as offline, but will still accept connections.")]
    public PropertyWrapper<bool>? EnableStatus { get; set; }

    [PropertyInfo("enable-query", false, "1.0.0")]
    [PropertyDescriptionAttribute("Enables GameSpy4 protocol server listener. Used to get information about server.")]
    public PropertyWrapper<bool>? EnableQuery { get; set; }

    [PropertyMinMax(10, 1000)]
    [PropertyInfo("entity-broadcast-range-percentage", 100, "1.16")]
    [PropertyDescriptionAttribute("Controls how close entities need to be before being sent to clients. Higher values means they'll be rendered from farther away, potentially causing more lag. This is expressed the percentage of the default value. For example, setting to 50 will make it half as usual. This mimics the function on the client video settings (not unlike Render Distance, which the client can customize so long as it's under the server's setting).")]
    public PropertyWrapper<int>? EntityBroadcastRangePercentage { get; set; }

    [PropertyInfo("force-gamemode", false)]
    [PropertyDescriptionAttribute("Force players to join in the default game mode. 'false' - Players join in the gamemode they left in. 'true' - Players always join in the default gamemode.")]
    public PropertyWrapper<bool>? ForceGamemode { get; set; }

    [PropertyMinMax(1, 4)]
    [PropertyInfo("function-permission-level", 2, "1.14.4")]
    [PropertyDescriptionAttribute("Sets the default permission level for functions. See 'permission level' for the details on the 4 levels.")]
    public PropertyWrapper<int>? FunctionPermissionLevel { get; set; }

    [PropertyInfo("gamemode", "survival", "1.14")]
    [PropertyDescriptionAttribute("Defines the mode of gameplay. If a legacy gamemode number is specified, it is silently converted to a gamemode name. 'survival' (0), 'creative' (1), 'adventure' (2), 'spectator' (3)")]
    public PropertyWrapper<string>? Gamemode { get; set; }

    [PropertyInfo("generate-structures", true, "1.1")]
    [PropertyDescriptionAttribute("Defines whether structures (such as villages) can be generated. 'false' - Structures are not generated in new chunks. 'true' - Structures are generated in new chunks. Note: Dungeons still generate if this is set to false.")]
    public PropertyWrapper<bool>? GenerateStructures { get; set; }

    [PropertyInfo("generator-settings", null, "1.8")]
    [PropertyDescriptionAttribute("The settings used to customize world generation. Follow its format and write the corresponding JSON string. Remember to escape all : with \\:.")]
    public PropertyWrapper<string>? GeneratorSettings { get; set; }

    [PropertyInfo("hardcore", false)]
    [PropertyDescriptionAttribute("If set to true, server difficulty is ignored and set to hard and players are set to spectator mode if they die.")]
    public PropertyWrapper<bool>? Hardcore { get; set; }

    [PropertyInfo("level-name", "world", "1.6.1")]
    [PropertyDescriptionAttribute("The 'level-name' value is used as the world name and its folder name. The player may also copy their saved game folder here, and change the name to the same as that folder's to load it instead. Characters such as ' (apostrophe) may need to be escaped by adding a backslash before them.")]
    public PropertyWrapper<string>? LevelName { get; set; }

    [PropertyInfo("level-seed", null, "1.6.1")]
    [PropertyDescriptionAttribute("Sets a world seed for the player's world, as in Singleplayer. The world generates with a random seed if left blank. Some examples are: minecraft, 404, 1a2b3c.")]
    public PropertyWrapper<string>? LevelSeed { get; set; }

    [PropertyInfo("level-type", "default", "1.1")]
    [PropertyDescriptionAttribute("Determines the type of map that is generated. 'default' - Standard world with hills, valleys, water, etc. 'flat' - A flat world with no features, can be modified with 'generator-settings'. 'largeBiomes' - Same as default but all biomes are larger. 'amplified' - Same as default but world-generation height limit is increased. 'buffet' - Only for 1.15 or before. Same as default unless generator-settings is set. 'default_1_1' - Only for 1.15 or before. Same as default, but counted as a different world type. 'customized' - Only for 1.15 or before. After 1.13, this value is no different than default, but in 1.12 and before, it could be used to create a completely custom world.")]
    public PropertyWrapper<string>? LevelType { get; set; }

    [PropertyMinMax(0, Int32.MaxValue)]
    [PropertyInfo("max-players", 20, "1.6.1")]
    [PropertyDescriptionAttribute("The maximum number of players that can play on the server at the same time. Note that more players on the server consume more resources. Note also, op player connections are not supposed to count against the max players, but ops currently cannot join a full server. However, this can be changed by going to the file called ops.json in the player's server directory, opening it, finding the op that the player wants to change, and changing the setting called bypassesPlayerLimit to true (the default is false). This means that that op does not have to wait for a player to leave in order to join. Extremely large values for this field result in the client-side user list being broken.")]
    public PropertyWrapper<int>? MaxPlayers { get; set; }

    [PropertyMinMax(0, Int32.MaxValue)]
    [PropertyInfo("max-tick-time", 60000)]
    [PropertyDescriptionAttribute("The maximum number of milliseconds a single tick may take before the server watchdog stops the server with the message, A single server tick took 60.00 seconds (should be max 0.05); Considering it to be crashed, server will forcibly shutdown. Once this criterion is met, it calls System.exit(1). -1 - disable watchdog entirely (this disable option was added in 14w32a)")]
    public PropertyWrapper<int>? MaxTickTime { get; set; }

    [PropertyMinMax(1, 29999984)]
    [PropertyInfo("max-world-size", 29999984)]
    [PropertyDescriptionAttribute("This sets the maximum possible size in blocks, expressed as a radius, that the world border can obtain. Setting the world border bigger causes the commands to complete successfully but the actual border does not move past this block limit. Setting the max-world-size higher than the default doesn't appear to do anything. Examples: Setting max-world-size to 1000 allows the player to have a 2000×2000 world border. Setting max-world-size to 4000 gives the player an 8000×8000 world border.")]
    public PropertyWrapper<int>? MaxWorldSize { get; set; }

    [PropertyInfo("motd", "A Minecraft Server")]
    [PropertyDescriptionAttribute("This is the message that is displayed in the server list of the client, below the name. The MOTD supports color and formatting codes. The MOTD supports special characters, such as '♥'. However, such characters must be converted to escaped Unicode form. An online converter can be found here. If the MOTD is over 59 characters, the server list may report a communication error.")]
    public PropertyWrapper<string>? Motd { get; set; }

    [PropertyInfo("network-compression-threshold", 256)]
    [PropertyDescriptionAttribute("By default it allows packets that are n-1 bytes big to go normally, but a packet of n bytes or more gets compressed down. So, a lower number means more compression but compressing small amounts of bytes might actually end up with a larger result than what went in. '-1' - disable compression entirely '0' - compress everything Note: The Ethernet spec requires that packets less than 64 bytes become padded to 64 bytes. Thus, setting a value lower than 64 may not be beneficial. It is also not recommended to exceed the MTU, typically 1500 bytes.")]
    public PropertyWrapper<int>? NetworkCompressionThreshold { get; set; }

    [PropertyInfo("online-mode", true, "1.6.1")]
    [PropertyDescriptionAttribute("Server checks connecting players against Minecraft account database. Set this to false only if the player's server is not connected to the Internet. Hackers with fake accounts can connect if this is set to false! If minecraft.net is down or inaccessible, no players can connect if this is set to true. Setting this variable to off purposely is called 'cracking' a server, and servers that are present with online mode off are called 'cracked' servers, allowing players with unlicensed copies of Minecraft to join. 'true' - Enabled. The server assumes it has an Internet connection and checks every connecting player. 'false' - Disabled. The server does not attempt to check connecting players.")]
    public PropertyWrapper<bool>? OnlineMode { get; set; }

    [PropertyMinMax(0, 4)]
    [PropertyInfo("op-permission-level", 4)]
    [PropertyDescriptionAttribute("Sets the default permission level for ops when using /op.")]
    public PropertyWrapper<int>? OpPermissionLevel { get; set; }

    [PropertyInfo("player-idle-timeout", 0, "1.6.1")]
    [PropertyDescriptionAttribute("If non-zero, players are kicked from the server if they are idle for more than that many minutes. Note: Idle time is reset when the server receives one of the following packets: Click Window, Enchant Item, Update Sign, Player Digging, Player Block Placement, Held Item Change, Animation (swing arm), Entity Action, Client Status, Chat Message, Use Entity")]
    public PropertyWrapper<int>? PlayerIdleTimeout { get; set; }

    [PropertyInfo("prevent-proxy-connections", false, "1.11")]
    [PropertyDescriptionAttribute("If the ISP/AS sent from the server is different from the one from Mojang Studios' authentication server, the player is kicked 'true' - Enabled. Server prevents users from using vpns or proxies. 'false' - Disabled. The server doesn't prevent users from using vpns or proxies.")]
    public PropertyWrapper<bool>? PreventProxyConnections { get; set; }

    [PropertyInfo("pvp", true)]
    [PropertyDescriptionAttribute("Enable PvP on the server. Players shooting themselves with arrows receive damage only if PvP is enabled. 'true' - Players can kill each other. 'false' - Players cannot kill other players (also known as Player versus Environment (PvE)). Note: Indirect damage sources spawned by players (such as lava, fire, TNT and to some extent water, sand and gravel) still deal damage to other players.")]
    public PropertyWrapper<bool>? Pvp { get; set; }

    [PropertyMinMax(1, 65535)]
    [PropertyInfo("query.port", 25565, "1.0.0")]
    [PropertyDescriptionAttribute("Sets the port for the query server (see enable-query).")]
    public PropertyWrapper<int>? QueryPort { get; set; }

    [PropertyInfo("rate-limit", 0, "1.16.2")]
    [PropertyDescriptionAttribute("Sets the maximum amount of packets a user can send before getting kicked. Setting to 0 disables this feature.")]
    public PropertyWrapper<int>? RateLimit { get; set; }

    [PropertyInfo("rcon.password", null, "1.0.0")]
    [PropertyDescriptionAttribute("Sets the password for RCON: a remote console protocol that can allow other applications to connect and interact with a Minecraft server over the internet.")]
    public PropertyWrapper<string>? RconPassword { get; set; }

    [PropertyMinMax(1, 65535)]
    [PropertyInfo("rcon.port", 25575, "1.0.0")]
    [PropertyDescriptionAttribute("Sets the RCON network port.")]
    public PropertyWrapper<int>? RconPort { get; set; }

    [PropertyInfo("resource-pack", null, "1.17")]
    [PropertyDescriptionAttribute("Optional URI to a resource pack. The player may choose to use it. Note that (in some versions before 1.15.2), the ':' and '=' characters need to be escaped with a backslash (\\), e.g. http\\://somedomain.com/somepack.zip?someparam\\=somevalue The resource pack may not have a larger file size than 250 MiB (Before 1.18: 100 MiB (≈ 100.8 MB)) (Before 1.15: 50 MiB (≈ 50.4 MB)). Note that download success or failure is logged by the client, and not by the server.")]
    public PropertyWrapper<string>? ResourcePack { get; set; }

    [PropertyInfo("resource-pack-prompt", null, "1.17")]
    [PropertyDescriptionAttribute("Optional, adds a custom message to be shown on resource pack prompt when require-resource-pack is used. Expects chat component syntax, can contain multiple lines.")]
    public PropertyWrapper<string>? ResourcePackPrompt { get; set; }

    [PropertyInfo("resource-pack-sha1", null)]
    [PropertyDescriptionAttribute("Optional SHA-1 digest of the resource pack, in lowercase hexadecimal. It is recommended to specify this, because it is used to verify the integrity of the resource pack. Note: If the resource pack is any different, a yellow message 'Invalid sha1 for resource-pack-sha1' appears in the console when the server starts. Due to the nature of hash functions, errors have a tiny probability of occurring, so this consequence has no effect.")]
    public PropertyWrapper<string>? ResourcePackSha1 { get; set; }

    [PropertyInfo("require-resource-pack", false, "1.17")]
    [PropertyDescriptionAttribute("When this option is enabled (set to true), players will be prompted for a response and will be disconnected if they decline the required pack.")]
    public PropertyWrapper<bool>? RequireResourcePack { get; set; }

    [PropertyInfo("server-ip", null)]
    [PropertyDescriptionAttribute("The player should set this if they want the server to bind to a particular IP. It is strongly recommended that the player leaves server-ip blank. Set to blank, or the IP the player want their server to run (listen) on.")]
    public PropertyWrapper<string>? ServerIp { get; set; }

    [PropertyMinMax(1, 65535)]
    [PropertyInfo("server-port", 25565, "1.6.1")]
    [PropertyDescriptionAttribute("Changes the port the server is hosting (listening) on. This port must be forwarded if the server is hosted in a network using NAT (if the player has a home router/firewall).")]
    public PropertyWrapper<int>? ServerPort { get; set; }

    [PropertyMinMax(3, 32)]
    [PropertyInfo("simulation-distance", 10, "1.18")]
    [PropertyDescriptionAttribute("Sets the maximum distance from players that living entities may be located in order to be updated by the server, measured in chunks in each direction of the player (radius, not diameter). If entities are outside of this radius, then they will not be ticked by the server nor will they be visible to players. 10 is the default/recommended. If the player has major lag, this value is recommended to be reduced.")]
    public PropertyWrapper<int>? SimulationDistance { get; set; }

    [PropertyInfo("snooper-enabled", true, "1.3.1")]
    [PropertyDescriptionAttribute("Sets whether the server sends snoop data regularly to http://snoop.minecraft.net. 'false' - disable snooping. 'true' - enable snooping.")]
    public PropertyWrapper<bool>? SnooperEnabled { get; set; }

    [PropertyInfo("spawn-animals", true)]
    [PropertyDescriptionAttribute("Determines if animals can spawn. 'true' - Animals spawn as normal. 'false' - Animals immediately vanish. If the player has major lag, it is recommended to turn this off/set to false.")]
    public PropertyWrapper<bool>? SpawnAnimals { get; set; }

    [PropertyInfo("spawn-monsters", true)]
    [PropertyDescriptionAttribute("Determines if monsters can spawn. 'true' - Enabled. Monsters appear at night and in the dark. 'false' - Disabled. No monsters. This setting has no effect if difficulty = 0 (peaceful). If difficulty is not = 0, a monster can still spawn from a spawner. If the player has major lag, it is recommended to turn this off/set to false.")]
    public PropertyWrapper<bool>? SpawnMonsters { get; set; }

    [PropertyInfo("spawn-npcs", true, "1.1")]
    [PropertyDescriptionAttribute("Determines whether villagers can spawn. 'true' - Enabled. Villagers spawn. 'false' - Disabled. No villagers.")]
    public PropertyWrapper<bool>? SpawnNpcs { get; set; }

    [PropertyInfo("spawn-protection", 16, "1.4.2")]
    [PropertyDescriptionAttribute("Determines the side length of the square spawn protection area as 2x+1. Setting this to 0 disables the spawn protection. A value of 1 protects a 3×3 square centered on the spawn point. 2 protects 5×5, 3 protects 7×7, etc. This option is not generated on the first server start and appears when the first player joins. If there are no ops set on the server, the spawn protection is disabled automatically as well.")]
    public PropertyWrapper<int>? SpawnProtection { get; set; }

    [PropertyInfo("text-filtering-config", null, "1.16.4")]
    [PropertyDescriptionAttribute("Determines the side length of the square spawn protection area as 2x+1. Setting this to 0 disables the spawn protection. A value of 1 protects a 3×3 square centered on the spawn point. 2 protects 5×5, 3 protects 7×7, etc. This option is not generated on the first server start and appears when the first player joins. If there are no ops set on the server, the spawn protection is disabled automatically as well.")]
    public PropertyWrapper<string>? TextFilteringConfig { get; set; }
    
    [PropertyInfo("use-native-transport", true)]
    [PropertyDescriptionAttribute("Linux server performance improvements: optimized packet sending/receiving on Linux 'true' - Enabled. Enable Linux packet sending/receiving optimization 'false' - Disabled. Disable Linux packet sending/receiving optimization")]
    public PropertyWrapper<bool>? UseNativeTransport { get; set; }

    [PropertyMinMax(3, 32)]
    [PropertyInfo("view-distance", 10, "1.6")]
    [PropertyDescriptionAttribute("Sets the amount of world data the server sends the client, measured in chunks in each direction of the player (radius, not diameter). It determines the server-side viewing distance. '10' is the default/recommended. If the player has major lag, this value is recommended to be reduced.")]
    public PropertyWrapper<int>? ViewDistance { get; set; }

    [PropertyInfo("white-list", false, "1.6.1")]
    [PropertyDescriptionAttribute("Enables a whitelist on the server. With a whitelist enabled, users not on the whitelist cannot connect. Intended for private servers, such as those for real-life friends or strangers carefully selected via an application process, for example. 'false' - No white list is used. 'true' - The file whitelist.json is used to generate the white list. Note: Ops are automatically whitelisted, and there is no need to add them to the whitelist.")]
    public PropertyWrapper<bool>? WhiteList { get; set; }

    [PropertyInfo("enforce-whitelist", false)]
    [PropertyDescriptionAttribute("Enforces the whitelist on the server. When this option is enabled, users who are not present on the whitelist (if it's enabled) get kicked from the server after the server reloads the whitelist file. 'false' - No user gets kicked if not on the whitelist. 'true' - Online users not on the whitelist get kicked.")]
    public PropertyWrapper<bool>? EnforceWhitelist { get; set; }
    
    public void LoadDefaults()
    {
        var type = typeof(ServerProperties);
        var properties = type.GetProperties();
        foreach (var property in properties)
        {
            var attributes = property.GetCustomAttributes(false);
            Type innerType = property.PropertyType.GenericTypeArguments.First();
            string? description = null;
            int? min = null;
            int? max = null;
            string iniName = null;
            object defaultValue = null;
            Version? addedInVersion = null;
            
            // Get all attribute data
            foreach (var attribute in attributes)
            {
                if (attribute is PropertyDescriptionAttribute)
                {
                    var attr = attribute as PropertyDescriptionAttribute;
                    description =  attr.Description;
                }
                else if (attribute is PropertyMinMaxAttribute)
                {
                    var attr = attribute as PropertyMinMaxAttribute;
                    min =  attr.Min;
                    max =  attr.Max;
                }
                else if (attribute is PropertyInfoAttribute)
                {
                    var attr = attribute as PropertyInfoAttribute;
                    iniName =  attr.IniName;
                    addedInVersion =  attr.AddedInVersion == null ? null : new Version( attr.AddedInVersion);
                    defaultValue =  attr.DefaultValue;
                }
            }
            
            // Init property with data
            var d1 = typeof(PropertyWrapper<>);
            Type[] typeArgs = { innerType };
            var makeme = d1.MakeGenericType(typeArgs);
            var realDefaultValue = Convert.ChangeType(defaultValue, innerType);
            var o = Activator.CreateInstance(makeme, BindingFlags.Instance | BindingFlags.NonPublic, null, new object[] {iniName, realDefaultValue, addedInVersion, description, min, max}, null, null);
            
            // Set real property of current instance 
            property.SetValue(this, o);
        }
    }

    public bool LoadFile(string fullFilePath, bool exceptionOnNotSupportedProperty = true)
    {
        if (!File.Exists(fullFilePath))
        {
            return false;
        }

        var configLines = File.ReadAllLines(fullFilePath).Where(x => !x.StartsWith("#") && !String.IsNullOrWhiteSpace(x)).ToList();

        foreach (var line in configLines)
        {
            var keyValue = line.Split('=');
            var value = keyValue[1].Split('#')[0].Trim();
            SetProperty(keyValue[0], value, exceptionOnNotSupportedProperty);
        }

        return true;
    }

    private void SetProperty(string iniName, string value, bool exceptionOnNotSupportedProperty = true)
    {
        var type = typeof(ServerProperties);
        var properties = type.GetProperties();

        for (int i = 0; i < properties.Length; i++)
        {
            var property = properties[i];
            Type innerType = property.PropertyType.GenericTypeArguments.First();
            var attribute = property.GetCustomAttributes(false).FirstOrDefault(x => x is PropertyInfoAttribute);

            if (attribute is not null)
            {
                var attr = attribute as PropertyInfoAttribute;
                if ( attr.IniName.Equals(iniName))
                {
                    var realProperty = property.GetValue(this, null);
                    var methodInfo = realProperty.GetType().GetMethod("SetValue");

                    if (innerType.IsEnum)
                    {
                        // TODO cast enum
                        continue;
                    }
                    
                    var realValue = Convert.ChangeType(value, innerType);
                    methodInfo.Invoke(realProperty, new object[] {realValue});
                    break;
                }
            }

            // Catch not supported, maybe new, properties
            if (i == properties.Length-1 && exceptionOnNotSupportedProperty)
            {
                throw new Exception($"Property '{iniName}' is not supported. This Exception can be prevented by setting param 'exceptionOnNotSupportedProperty' to 'false'");
            }
        }
    }

    public void WriteFile(string fullFilePath, bool writeDefaults = false, bool writeDescriptions = false,
        Version? compatibilityVersion = null)
    {
        StringBuilder configBuilder = new StringBuilder();
        configBuilder.AppendLine("#Minecraft server properties");
        configBuilder.AppendLine($"#{DateTime.UtcNow.ToString("O")}");
        configBuilder.AppendLine("#Created with StefmDE.MinecraftProperties");
        configBuilder.AppendLine();
        
        var type = typeof(ServerProperties);
        var properties = type.GetProperties();
        foreach (var property in properties)
        {
            var realProp = (dynamic)property.GetValue(this);

            // Defaults?
            if (!writeDefaults && realProp.IsDefault)
            {
                continue;
            }

            // Version compatible?
            if (compatibilityVersion is not null && realProp.AddedInVersion is not null &&
                realProp.AddedInVersion > compatibilityVersion)
            {
                continue;
            }

            // With description?
            if (writeDescriptions && !String.IsNullOrWhiteSpace(realProp.Description))
            {
                configBuilder.AppendLine();
                configBuilder.Append("#");
                configBuilder.AppendLine(realProp.Description);
            }
            
            // Write property
            configBuilder.Append(realProp.IniName);
            configBuilder.Append("=");
            configBuilder.AppendLine(realProp.Value is null ? "" : realProp.Value.ToString().ToLower());
        }
        
        File.WriteAllText(fullFilePath, configBuilder.ToString());
    }
}