-- このluaスクリプトは、SQ_XXXX.csv の ADV シートから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_026_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("401036","001","401036001","content_animationpack__common","FacialPack","Actor002")
	template1()

end

function Play()
	StartPlay()


	--★★キャメロット軍兵士_下位★★:ヤツらを片づけてくれたんだな、ありがとう！<br>お前に頼んだ甲斐があったよ
	Talk(Actor002,"NPCNAME_0351","speech","N","SQ_0001_99001")


	--★★キャメロット軍兵士_下位★★:今回の報酬だ、受け取ってくれ<br>またなにかあったら頼むな
	Talk(Actor002,"NPCNAME_0351","speech","N","SQ_0001_99002")
	
	--エンジニア（中嶋さん）の機能マージ待ち（2/17）
	open_subquest_window_complete()

	EndPlay()
end




function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("401036","001","401036001","content_animationpack__common","FacialPack","Actor002")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
