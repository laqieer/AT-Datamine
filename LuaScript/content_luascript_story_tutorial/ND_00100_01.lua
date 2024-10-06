Include("content_luascript_common","ADVSmallPack")

function Load()
	InitializeLoadActive()
	--Actor001 = InitializeActiveCharacter("Player","101003001","101003001","content_animationpack__common","MotionPack","Com_Std01_Loop_m")
	--Actor001 = InitializeActiveCharacter_GendaiPlayer()
	Actor002 = InitializeActiveCharacter("prorog_a001_Schoolboy","401001001","401001001","content_animationpack_100_100mobm","MotionPack_100MobM","Com_Std01_Loop_m")
	Actor003 = InitializeActiveCharacter("prorog_a002_Schoolgirl","401002001","401002001","content_animationpack_100_100mobf","MotionPack_100MobF","Com_Std01_Loop_f")
end

function Play()
	StartPlayActive()


	--★★現代編NPC　現代編学生（男）★★:よっ、転校生！<br>これから仲良くやろうぜ！よろしくな！
	Talk(Actor002,"NPCNAME_0001","speech","N","ND_00100_010001")


	--★★現代編NPC　現代編学生（女）★★:わからないことがあったら<br>なんでも聞いてね
	Talk(Actor003,"NPCNAME_0002","speech","N","ND_00100_010002")

	EndPlayActive()
end



function InitializeActiveCharacter_GendaiPlayer()

	local characterId = system.GetPlayerModelInfo("CharacterId")
	local styleId = system.GetPlayerModelInfo("StyleId")
	local labelChara = system.GetPlayerModelInfo("LabelChara")
	local facialAssetbundleName = system.GetPlayerModelInfo("FacialPath")
	local facialFileName = system.GetPlayerModelInfo("FacialName")

	if characterId == "101003" then
		-- 現代編主人公：男１
		animationAssetbundleName = "content_animationpack__common"
		animationFileName = "MotionPack"
		animationName = "Com_Std01_Loop_m"
	elseif characterId == "101005" then
		-- 現代編主人公：男２
		animationAssetbundleName = "content_animationpack__common"
		animationFileName = "MotionPack"
		animationName = "Com_Std01_Loop_m"
	elseif characterId == "101007" then
		-- 現代編主人公：男３
		animationAssetbundleName = "content_animationpack__common"
		animationFileName = "MotionPack"
		animationName = "Com_Std01_Loop_m"
	elseif characterId == "101004" then
		-- 現代編主人公：女１
		animationAssetbundleName = "content_animationpack__common"
		animationFileName = "MotionPack"
		animationName = "Com_Std01_Loop_f"
	elseif characterId == "101006" then
		-- 現代編主人公：女２
		animationAssetbundleName = "content_animationpack__common"
		animationFileName = "MotionPack"
		animationName = "Com_Std01_Loop_f"
	else
		-- 現代編主人公：女３
		animationAssetbundleName = "content_animationpack__common"
		animationFileName = "MotionPack"
		animationName = "Com_Std01_Loop_f"
	end

	return InitializeActiveCharacter("Player", characterId, styleId, animationAssetbundleName, animationFileName, animationName)
end


function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeActiveCharacter_Preload("prorog_a001_Schoolboy","401001001","401001001","content_animationpack_100_100mobm","MotionPack_100MobM","Com_Std01_Loop_m")
	InitializeActiveCharacter_Preload("prorog_a002_Schoolgirl","401002001","401002001","content_animationpack_100_100mobf","MotionPack_100MobF","Com_Std01_Loop_f")
end
