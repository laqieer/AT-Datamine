-- このluaスクリプトは、CO_101064_0102.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_02","110111_02_h")
Include("content_adv_advsmall_110111_02","Template110111_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110111_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_014_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_02_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_02,CameraPos110111_02_003)
	InitializeTemplateRandomCamera110111_02()
	InitializeTemplate110111_02()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(115117)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	template1()
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★ノワール★★:ついついマスターと話し込んでしまった…<br>ディナタン、怒ってるかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01020002")


	--★★市民（男）★★:てめえ、ふざけんな！
	Talk(Actor003,"NPCNAME_0280","speech","N","CO_101064_01020004")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:ん、なんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01020006")

	change_face(Actor001,"Normal")

	--★★ノワール★★:酔っ払いたちが<br>路地裏でケンカでもしてるのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01020008")


	--★★市民（男）★★:くそっ酔ってさえいなけりゃ…
	Talk(Actor003,"NPCNAME_0280","speech","N","CO_101064_01030002")


	--★★リアム★★:酔ってさえいなけりゃ<br>俺に拳が当たると思っているのか？
	Talk(Actor002,"NPCNAME_0259","speech","N","CO_101064_01030004")


	--★★リアム★★:おぼつかない足取りで拳を振るったって<br>さっきみてえにすっ転ぶのがオチだ
	Talk(Actor002,"NPCNAME_0259","speech","N","CO_101064_01030005")


	--★★リアム★★:大ケガしねえうちにさっさと消えな
	Talk(Actor002,"NPCNAME_0259","speech","N","CO_101064_01030006")


	--★★市民（男）★★:ち、ちくしょうっ！！
	Talk(Actor003,"NPCNAME_0280","speech","N","CO_101064_01030007")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:あれ？誰もいない…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01030009")

	PlayAction(Actor001,"to  Std_Worry")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ケンカを売られていたヤツの声<br>どこかで聞いたことがある気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01030010")

	change_face(Actor001,"Sad")

	--★★ノワール★★:リアムさん…？<br>いや、まさかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101064_01030011")

-- ▼直接出力
local trustParam = set_communication_acquired("リアム_コミュランク", "リアム_親密度")
-- ▲直接出力
-- ▼直接出力
open_trust_release(Actor002, trustParam)
-- ▲直接出力
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
	InitializeLoad_Preload()
	load_area_scene_preload(115117)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101064","001","101064001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	system.PreLoadRequest(CameraAssetBundleName110111_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
