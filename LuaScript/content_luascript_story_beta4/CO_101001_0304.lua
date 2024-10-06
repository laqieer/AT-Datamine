-- このluaスクリプトは、CO_101001_0304.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110011_01","110011_01_h")
Include("content_adv_advsmall_110011_01","Template110011_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",200,CharaPos110011_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110011_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_004)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110011_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_003_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110011_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_504_01_StdController","to Std_Loop",CameraAssetBundleName110011_01,CameraPos110011_01_006)
	InitializeTemplateRandomCamera110011_01()
	InitializeTemplate110011_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110011)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:できた～！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03040002")

	PlayAction(Actor004,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:あたしもこれで終わり！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03040003")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:思ってたより早くに終わったな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03040004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ガウェイン★★:いや～、本当に助かったぜ！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03040005")

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力

	--★★ガウェイン★★:やっぱみんなで協力すると<br>早く終わっていいな！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03040006")

	PlayAction(Actor004,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ラグネル", "肯定2")
-- ▲直接出力

	--★★ラグネル★★:ありがとうね、ティルちゃん！<br>ノワールも！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03040007")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ああ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03040008")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:お役に立てたようで何よりです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03040010")


	--★★ガウェイン★★:よっし、先生に出してこよっと！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","CO_101001_03040011")

-- ▼直接出力
 --退場のためカメラを指定
setup_small_camera_start(Camera004)
-- ▲直接出力
	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:あーっ、待ってよガウェイン！<br>あたしも行く！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","CO_101001_03040013")

-- ▼直接出力
　--フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN)
PlayActionDirect(Actor003,"to Run")
wait_time(0.3)
PlayActionDirect(Actor004,"to Run")
wait_time(1.7)
PlayActionDirect(Actor003,"to Std_Loop")
PlayActionDirect(Actor004,"to Std_Loop")
wait_time(CHARA_IN_WAIT)
Hide(Actor003)
Hide(Actor004)
setup_small_camera_start()
　--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:騒がしい奴らだなあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03040015")

-- ▼直接出力
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.3)
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.2)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:それはいいとして、どうだった？<br>疲れなかったか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_03040017")

-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力

	--★★ティルフィング★★:いえ、全然
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03040018")


	--★★ティルフィング★★:同じ学び舎で生活する者同士<br>力を合わせてひとつの課題に取り組む…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03040020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ティルフィング★★:とても新鮮で、楽しい体験でした
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_03040021")

-- ▼直接出力
local trustParam = set_communication_rankup("ティルフィング_コミュランク", "ティルフィング_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
 --open_trust_gauge(Actor002, trustParam)
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
	load_area_scene_preload(110011)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110011_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
