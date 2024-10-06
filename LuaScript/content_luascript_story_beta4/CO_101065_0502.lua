-- このluaスクリプトは、CO_101065_0502.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_02","112041_02_h")
Include("content_adv_advsmall_112041_02","Template112041_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_02_001,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_001)
	Camera003 = SetTemplate("Actor003",nil,CharaPos112041_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_018_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_005)
	Camera004 = SetTemplate("Actor004",nil,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_008_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	Camera005 = SetTemplate("Actor005",nil,CharaPos112041_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_005_01_StdController","to Std_Loop",CameraAssetBundleName112041_02,CameraPos112041_02_004)
	InitializeTemplateRandomCamera112041_02()
	InitializeTemplate112041_02()
-- ▼直接出力
sakabin = setup_prop_object(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
on_parent(sakabin ,Actor003, "Loc_weapon_constrint_R", sakabin_offset2 )
-- ▲直接出力
-- ▼直接出力
Hide(Actor004)
-- ▲直接出力
-- ▼直接出力
Hide(Actor005)
-- ▲直接出力
-- ▼直接出力
 --黒背景読込
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
keep_ik_lookat(Actor001,Actor002,"J_Head")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	Actor005 = InitializeCharacter_3D("401013","001","401013001","content_animationpack__common","FacialPack","Actor005")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to Sit01_Loop")
	PlayAction(Actor001,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("キッス", "肯定")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★キッス★★:んん～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020002")

	change_face(Actor002,"Special")

	--★★キッス★★:やっぱり仕事のイライラは<br>お酒を飲んで忘れるのが一番ね♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020003")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もう酔っ払ってる…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020005")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★キッス★★:なによぉ。ラビットちゃんぜんぜんのんでないじゃな～い
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020006")


	--★★キッス★★:アタシのさけがのめないとかそんなことはいわせないぞ♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020007")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101065_05020009","CO_101065_05020010")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:それじゃあ一杯…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020012")

	PlayAction(Actor001,"to Sit01_Loop")
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	change_face(Actor001,"Anger")

	--★★ノワール★★:ってなるか！学生は飲酒禁止だ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020013")

-- ▼直接出力
PlayPartVoice("キッス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Special")

	--★★キッス★★:なによぉつまんないの～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020014")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いやダメだから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020016")

	change_face(Actor001,"Sad")

	--★★ノワール★★:学生の俺に飲ませたらあんたも怒られるぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020017")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Special")

	--★★キッス★★:ええ～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020018")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさんっていつも酒場にいるのに酒に弱いんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020020")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Special")

	--★★キッス★★:なによぉだれがなにによわいって～？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020021")


	--★★キッス★★:いっておくけどアタシちょお～つよいんだからね～！
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020022")

-- ▼直接出力
PlayPartVoice("キッス", "笑い")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★キッス★★:なみのおとこなんか<br>ひとひねりなんだからぁ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020023")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:もうロレツが怪しいじゃないか…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020024")

-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.8, 0.5, 0.7, 0.5} , 1)
keep_ik_lookat(Actor002,Actor005,"J_Head")
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("市民_男1", "怒り")
-- ▲直接出力

	--★★市民（男）②★★:おい、てめぇ！！情報屋のキッスだろ！！
	Talk(Actor005,"NPCNAME_0279","speech","N","CO_101065_05020026")


	--★★市民（男）②★★:依頼を取ってくんのが仕事のクセにろくに仕事も情報も寄越さねえ詐欺師め！
	Talk(Actor005,"NPCNAME_0279","speech","N","CO_101065_05020027")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:お、おい…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020028")

-- ▼直接出力
PlayPartVoice("キッス", "悩む")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★キッス★★:なによぉ。うるさいおとこねぇ～アタシのこのみじゃないわ～
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020029")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Special")

	--★★キッス★★:あんたにおしごとあげなかったのはあげられるレベルのつよさじゃなかっただけよ
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020030")

	PlayAction(Actor005,"to  Std_Angry")
-- ▼直接出力
PlayPartVoice("市民_男1", "激怒")
-- ▲直接出力

	--★★市民（男）②★★:んだと！？オレがよえーって言いてぇのか！！
	Talk(Actor005,"NPCNAME_0279","speech","N","CO_101065_05020031")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("キッス", "肯定3")
-- ▲直接出力

	--★★キッス★★:アタシがしごとふらなかったんだからそうなんじゃな～い？
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020032")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("市民_男1", "怒り")
-- ▲直接出力

	--★★市民（男）②★★:このっ…！！
	Talk(Actor005,"NPCNAME_0279","speech","N","CO_101065_05020033")

-- ▼直接出力
setup_small_camera_start(Camera001)
Hide(Actor005)
Appear(Actor004)
lookat_delay_weight(Actor002, {0.6, 0.5, 0.7, 0.5} , 1)
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",0.5)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "怒り")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Anger")

	--★★ノワール★★:おい、止せって
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101065_05020035")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera002)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "喜び")
-- ▲直接出力

	--★★キッス★★:きゃー！らびっとちゃんかっこいい～♪
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020036")


	--★★キッス★★:さぁっすが<br>あのひとがえらんだだけあるわね
	Talk(Actor002,"CHRNAME_KISS","speech","L","CO_101065_05020037")

-- ▼直接出力
set_enable_auto_lookat(Actor001,false)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ケイ", "笑い")
-- ▲直接出力

	--★★ケイ★★:おっと手が滑った
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101065_05020039")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("キッス", "苦しみ")
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor002,"Normal")

	--★★キッス★★:うっ！
	Talk(Actor002,"CHRNAME_KISS","speech","N","CO_101065_05020041")

	close_cutin()
-- ▼直接出力
setup_small_camera_start(Camera004)
set_enable_auto_lookat(Actor001,true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:ケ、ケイ！？いつの間に！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020043")

-- ▼直接出力
PlayPartVoice("ケイ", "肯定")
-- ▲直接出力

	--★★ケイ★★:なに、少し野暮用でな
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101065_05020044")


	--★★ケイ★★:ノワール、今日は面倒をかけたなそこの御仁にも詫びておいてくれ
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101065_05020045")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ケイ", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ケイ★★:この方は仕事はデキるのだが酒の席での失敗が多くてな…
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101065_05020046")

	PlayAction(Actor004,"to  Std_Talk")
	change_face(Actor004,"Normal")

	--★★ケイ★★:帰るぞ、キッス殿<br>さあ、歩きたまえ
	Talk(Actor004,"CHRNAME_KAY","speech","L","CO_101065_05020048")

-- ▼直接出力
 --黒背景に移行
CloseTalkWindow()
show_image("101010140", 0.0, 0.0, BLACK_WHITE_TIME,false,false)
set_scale_image(20,20)
wait_time(BLACK_WHITE_TIME + BLACK_WHITE_WAIT_TIME)
Hide(Actor004)
Hide(Actor002)
Hide(Actor005)

-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ジェラルド", "笑い")
-- ▲直接出力

	--★★酒場店主★★:いつも回収ありがとうございますまたお越しくださいませ
	Talk(Actor003,"NPCNAME_0263","speech","L","CO_101065_05020050")

-- ▼直接出力
setup_small_camera_start()
--白黒終了フェードアウト
CloseTalkWindow() --疑似バトルならclose_speech_window(
hide_image(BLACK_WHITE_TIME)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:いつも…あんななのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020051")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ジェラルド", "肯定2")
-- ▲直接出力

	--★★酒場店主★★:はいいつもあんなです
	Talk(Actor003,"NPCNAME_0263","speech","L","CO_101065_05020052")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そっか…<br>マスターもケイも大変だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020053")

	change_face(Actor001,"Normal")

	--★★ノワール★★:キッスさん、なにか言いかけてたけど
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020055")

-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力

	--★★ノワール★★:ちょっと気になるな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101065_05020056")

-- ▼直接出力
local trustParam = set_communication_rankup("キッス_コミュランク", "キッス_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
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
setup_prop_object_preload(10101015)
sakabin_offset2 = {0,0,0,0,0,0}
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101065","001","101065001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401027","001","401027001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101040","001","101040001","content_animationpack__common","FacialPack","Actor004")
	InitializeCharacter_3D_Preload("401013","001","401013001","content_animationpack__common","FacialPack","Actor005")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
