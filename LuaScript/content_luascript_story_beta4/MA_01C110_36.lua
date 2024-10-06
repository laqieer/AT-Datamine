-- このluaスクリプトは、MA_01C110_36.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110111_01","110111_01_h")
Include("content_adv_advsmall_110111_01","Template110111_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110111_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_003)
	Camera002 = SetTemplate("Actor002",65,CharaPos110111_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_006_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110111_01_001,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_001)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110111_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName110111_01,CameraPos110111_01_004)
	InitializeTemplateRandomCamera110111_01()
	InitializeTemplate110111_01()
-- ▼直接出力
Hide(Actor003)
Hide(Actor004)
set_pos(Actor003,CharaPos110111_01_101)
set_pos(Actor004,CharaPos110111_01_104)
-- ▲直接出力
-- ▼直接出力
load_sound("BGM_ADV_Invasion2")
-- ▲直接出力
-- ▼直接出力
	-- 背景移動回転スケール
	local bg = get_object("BG")
	set_pos(bg,{-10,0,10})

	-- 固定モブ移動回転スケール
	local pro = get_object("Pro_1101_45")
	set_pos(pro,{-10,0,10})

-- ▲直接出力
-- ▼直接出力
load_image("104000170", "content_still_10400017_image", "104000170_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110111)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor001,"to Greet_one")
-- ▼直接出力
 --PlayPartVoice("ノワール", "挨拶")
-- ▲直接出力

	--★★ノワール★★:モルドレッド？<br>なにしてるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360002")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力

	--★★モルドレッド★★:見てわかんねぇのかよ<br>メシ買ってんだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360003")

-- ▼直接出力
wait_time(0.2)
ShowImageItem(104000170)
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:メシって…<br>猫の形した飴細工が？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360004")

-- ▼直接出力
CloseTalkWindow()
HideImageItem()
setup_small_camera_start()
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "照れ")
-- ▲直接出力

	--★★モルドレッド★★:…なんか文句あんのかよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360005")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:文句っていうか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360006")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01C110_360007","MA_01C110_360008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:へえ、こんなのあるんだな<br>俺も買って行ってやろうかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360010")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:俺も買って行って？<br>オイ、勘違いすんなよてめえ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360011")

	change_face(Actor002,"Anger")

	--★★モルドレッド★★:これはオレが腹減ったから<br>買ってるだけだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:アイツにやるにしたって<br>ただのついでだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360014")

	change_face(Actor001,"Normal")

	--★★ノワール★★:？なにを怒ってるのかわからないけど<br>…まぁ、いいか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:カワイイ趣味してるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360017")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★モルドレッド★★:はぁ？なに言ってんだてめえ<br>これはただ、アイツに――
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360018")

-- ▼直接出力
 --PlayPartVoice("モルドレッド", "苦しみ")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:…いや、なんでもねえ<br>忘れやがれ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360019")

	goto Block1end

::Block1end::
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "笑い")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:にしても、呑気なもんだぜ<br>こんなときに学園祭なんてよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360021")

	change_face(Actor002,"Smile")

	--★★モルドレッド★★:…ま、おかげでクラリスの奴も<br>ちょっとは元気出たみたいだがよ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360022")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:クラリスの具合はどうなんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★モルドレッド★★:体はほとんど問題ねえよ<br>２、３日寝てりゃ回復するだろってさ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360024")

	change_face(Actor002,"Smile")

	--★★モルドレッド★★:自分も学園祭を回りたかった～って<br>メソメソしてやがったぜ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360025")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それでお土産を買ってあげてるんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Worry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "怒り")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★モルドレッド★★:…チッ<br>性根の悪ィヤロウだ
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360027")

-- ▼直接出力
CloseTalkWindow()
bgm_play("BGM_ADV_Invasion2")
IN_RUN_2P(Actor003,CharaPos110111_01_001,Actor004,CharaPos110111_01_004)
PlayActionDirect(Actor001,"to Wlk")
PlayActionDirect(Actor002,"to Wlk")
turn_lookat(Actor001,Actor004,0.5)
turn_lookat(Actor002,Actor003,0.5)
PlayActionDirect(Actor001,"to Std_Loop")
PlayActionDirect(Actor002,"to Std_Loop")
-- ▲直接出力

	--★★市民（男）★★:ば、バルバロイが街に！
	Talk(Actor003,"NPCNAME_0132","speech","L","MA_01C110_360028")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★市民（男）②★★:早く隠れるんだ！
	Talk(Actor004,"NPCNAME_0133","speech","L","MA_01C110_360029")

-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("モルドレッド", "落胆")
-- ▲直接出力

	--★★モルドレッド★★:クソッ、また来やがったか
	Talk(Actor002,"CHRNAME_MORDRED","speech","L","MA_01C110_360031")

-- ▼直接出力
setup_small_camera_start(RndCamera002)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Angry")
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Serious")

	--★★ノワール★★:行こう、モルドレッド！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01C110_360032")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
preload_sound("BGM_ADV_Invasion2")
load_image_preload("104000170", "content_still_10400017_image", "104000170_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(110111)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101022","001","101022001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401011","001","401011001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110111_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
