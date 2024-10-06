-- このluaスクリプトは、MA_01C111_43.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111015_01","111015_01_h")
Include("content_adv_advsmall_111015_01","Template111015_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111015_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Chr_005_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_001)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111015_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111015_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Chr_526_02_StdController","to Std_Loop",CameraAssetBundleName111015_01,CameraPos111015_01_008)
	InitializeTemplateRandomCamera111015_01()
	InitializeTemplate111015_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
sword_01 = set_object("content_weapon_102017001", "weapon_model_102017001", true)
weapon_offset = {0,0,0,0,0,0}
set_pos(Actor001,{2.2,0.033,1.3})
Hide(Actor003)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat_all(false)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Serious2")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111015)
	Actor001 = InitializeCharacter_3D("101015","003","101015003","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
 --PlayPartVoice("モルガン","挨拶")
-- ▲直接出力

	--★★モルガン★★:なんの苦楽もない園で水入らず──…
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430002")

-- ▼直接出力
 --PlayPartVoice("モルガン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:どうかしら、アーサー
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430004")

-- ▼直接出力
 --PlayPartVoice("アーサー","笑い")
-- ▲直接出力

	--★★アーサー★★:うなずくと思うか？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン","悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルガン★★:…いいえ
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430006")

	PlayAction(Actor001,"to  Std_No")
	change_face(Actor001,"Sad")

	--★★アーサー★★:それは忌むべきだ<br>この世を蝕む毒そのものだよ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430007")


	--★★モルガン★★:その毒をもって毒を制する？
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430008")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("アーサー","肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:生まれ持ってしまったからな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430009")

-- ▼直接出力
 --PlayPartVoice("モルガン","納得")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:その毒に酔うことだってできたはずよ
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430010")

	PlayAction(Actor001,"to  Std_Sad01")
	change_face(Actor001,"Sad")

	--★★アーサー★★:…いつも言いつけを守れないでいるな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★モルガン★★:優しい子
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430013")

-- ▼直接出力
 --PlayPartVoice("アーサー","笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★アーサー★★:どこをどう見たら？
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430015")

-- ▼直接出力
 --PlayPartVoice("モルガン","挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:継承者に選択肢を託したのでしょう？<br>…自分の宿願自体が正しいのかわからずに
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430016")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルガン★★:事前に手を打つことだって<br>できたはずよね？
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★モルガン★★:でも正しさとは捉える人によって…<br>選んだ道によって変わってくるものだから
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430018")


	--★★モルガン★★:…気に入っていたものね<br>ノワールくんのこと
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430019")

-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayActionDirect(Actor001,"to  Std_Worry")
 --PlayPartVoice("アーサー","落胆")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:ノワールにとっては正答だったのだろうな
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430020")

-- ▼直接出力
 --PlayPartVoice("モルガン","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:でもその選択のおかげで<br>世界に負の遺産が産まれることとなる
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430021")

	change_face(Actor002,"Sad")

	--★★モルガン★★:見過ごせないのね、貴方は
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430023")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayActionDirect(Actor001,"to Std_Loop")
 --PlayPartVoice("アーサー","悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★アーサー★★:わがままを聞いてくれるか、義姉さん
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430025")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera002)
Appear(Actor003)
 --PlayPartVoice("モルガン","笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★モルガン★★:そう言われるとねえ
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430026")

-- ▼直接出力
bgm_play("BGM_ADV_Serious2")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(Camera003)
 --PlayPartVoice("モーロノエー","怒り")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★モーロノエー★★:まったく、嫌になるわ<br>魔女の真似事、見苦しくってみてらんない
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_430028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor003,"to  Std_No")
-- ▼直接出力
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力

	--★★モーロノエー★★:甘ったれの友情ごっこ<br>恥ずかしくって耐えられない
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_430029")

-- ▼直接出力
 --PlayPartVoice("モーロノエー","笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モーロノエー★★:でも、大丈夫♪<br>すべては順調♪
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_430030")

	PlayAction(Actor003,"to  Std_Talk")

	--★★モーロノエー★★:だってねぇ、アーサー！<br>ここには『本物』の王様が！
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_430031")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★アーサー★★:楽園の奥で玉座にふんぞり返ることが<br>王のすべきことではない
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430033")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルガン","肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルガン★★:…そうね。アーサー
	Talk(Actor002,"CHRNAME_MORGAN","speech","L","MA_01C111_430035")

-- ▼直接出力
 --PlayPartVoice("アーサー","肯定2")
-- ▲直接出力

	--★★アーサー★★:間違った世界を壊し<br>その瓦礫すら跡形もなく消え去る
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430036")

-- ▼直接出力
setup_small_camera_start(Camera003)
turn_lookat(Actor001,Actor003,0)
 --PlayPartVoice("モーロノエー","驚き")
-- ▲直接出力
	change_face(Actor003,"Anger")

	--★★モーロノエー★★:アーサー？
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_430038")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01B109_12_Sword")
-- ▲直接出力
-- ▼直接出力
wait_time(0.22)
-- ▲直接出力
-- ▼直接出力
on_parent(sword_01,Actor001,"Loc_weapon_constrint_R",weapon_offset)
set_animationbattlecontroller(Actor001, 1, false)
PlayActionDirect(Actor001,"ToIdle")
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start(RndCamera008)
 --PlayPartVoice("アーサー","笑い")
-- ▲直接出力

	--★★アーサー★★:そうあるべきではないか？<br>妖精の模造品よ
	Talk(Actor001,"CHRNAME_ARTHUR","speech","L","MA_01C111_430039")

-- ▼直接出力
setup_small_camera_start(Camera003)
-- ▲直接出力

	--★★モーロノエー★★:――！！
	Talk(Actor003,"CHRNAME_SISTERS_1","speech","L","MA_01C111_430041")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0.0, 0.0,0.3,false,false)
set_scale_image(20,20)
wait_time(0.3+ BLACK_WHITE_WAIT_TIME)
-- ▲直接出力

	--★★アーサー★★:語り継がれることなどなく。永久に
	Talk(Actor001,"CHRNAME_ARTHUR","simple","N","MA_01C111_430043")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
set_object_preload("content_weapon_102017001", "weapon_model_102017001", true)
weapon_offset = {0,0,0,0,0,0}
preload_sound("BGM_ADV_Serious2")
	InitializeLoad_Preload()
	load_area_scene_preload(111015)
	InitializeCharacter_3D_Preload("101015","003","101015003","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101042","001","101042001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111015_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
