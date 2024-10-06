-- このluaスクリプトは、CO_101030_0703.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114031_01","114031_01_h")
Include("content_adv_advsmall_114031_01","Template114031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114031_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_520_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_002)
	Camera003 = SetTemplate("Actor003",nil,CharaPos114031_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Npc_006_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_006)
	Camera004 = SetTemplate("Actor004",nil,CharaPos114031_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Npc_007_01_StdController","to Std_Loop",CameraAssetBundleName114031_01,CameraPos114031_01_005)
	InitializeTemplateRandomCamera114031_01()
	InitializeTemplate114031_01()
-- ▼直接出力
tegami = setup_prop_object(10106003)
off_active(tegami)
tegami_offset = {0,0,0,0,0,0}
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002,false)
lookat_delay_weight(Actor002, {0.4, 0.08, 0.9, 0.6} , 1)
keep_ik_lookat(Actor002,Actor003,"J_Head")
set_enable_auto_lookat(Actor001,false)
lookat_delay_weight(Actor001, {0.4, 0.08, 0.8, 0.6} , 1)
keep_ik_lookat(Actor001,Actor003,"J_Head")
-- ▲直接出力
-- ▼直接出力
slidemove(Actor003, 0.4, -0.232, 2.47, 0)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:トビーくん今日もみんなからの手紙を預かって来たわ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("子供_男2","0012")
-- ▲直接出力

	--★★子供（男）②★★:やったあ、ありがとう！
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030003")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
wait_time(0.6)
on_parent(tegami,Actor002, "Loc_weapon_constrint_L", tegami_offset)
on_active(tegami)
SkipDefaultMotion(Actor002)
PlayActionDirect(Actor002,"to ReadLetter")
wait_time(0.6)
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
-- ▲直接出力
-- ▼直接出力
se_play("SE_ADV_MA_01105_28_Paper")
wait_time(0.7)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★エレイン★★:読むわねえーっと…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(0.9)
-- ▲直接出力
-- ▼直接出力
CloseTalkWindow()
fadeout(0,0,0,1.0, 0.6)
wait_time(1.2)
off_parent(tegami)
off_active(tegami)
PlayActionDirect(Actor002,"to Std_Loop")

fadein(1)
wait_time(1.2)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "挨拶")
-- ▲直接出力

	--★★子供（男）②★★:ねえ、エレインお姉ちゃん
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030006")

-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:うん、なあに？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030007")

	PlayAction(Actor003,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）②★★:ぼくがこの村に来ちゃってさお父さん、心配してないかな？
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030008")


	--★★子供（男）②★★:お父さんにお手紙出したほうがいいかなあ
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030009")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:トビー、そのことなんだけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07030010")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("エレイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★エレイン★★:すごく…すごくいいアイデアだと思う！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030012")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★エレイン★★:このあいだロンディニウムにいったときにトビーくんのお父さんにお会いしてね
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030013")

	change_face(Actor002,"Sad")

	--★★エレイン★★:今は街の復興作業で忙しくてしばらくこっちには来られないそうだから
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030014")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:手紙を書いてあげたらきっと喜ぶわ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030015")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(2)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★子供（男）②★★:…
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030017")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
keep_delay_ik_lookat(Actor001,Actor003,"J_Head",0.6)
PlayPartVoice("子供_男2", "悲しみ")
-- ▲直接出力

	--★★子供（男）②★★:お姉ちゃん、泣いてるの？
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030018")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "驚き")
-- ▲直接出力

	--★★エレイン★★:えっ？泣いてなんかいないわよ。どうして？
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030019")

-- ▼直接出力
PlayPartVoice("子供_男2", "悩む")
-- ▲直接出力

	--★★子供（男）②★★:すごく声が辛そうだったから
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030020")

	PlayAction(Actor002,"to  Std_Talk")

	--★★エレイン★★:トビーくんの気のせいじゃないかな？私は元気だよ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030021")


	--★★子供（男）②★★:そう…
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030022")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "挨拶")
-- ▲直接出力

	--★★子供（男）②★★:ぼく、今日はもう帰るね
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030023")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("エレイン", "肯定2")
-- ▲直接出力

	--★★エレイン★★:こ、今度ロンディニウムに行ったらお父さんに手紙のことを話しておくわ
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030024")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("子供_男2", "肯定")
-- ▲直接出力

	--★★子供（男）②★★:うん、お願い
	Talk(Actor003,"NPCNAME_0247","speech","L","CO_101030_07030025")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
se_play("SE_ADV_CO_101030_0303_Foot_2_Peaple")
wait_time(1.1)

Hide(Actor003)
Hide(Actor004)
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor001,Actor002,"J_Head")
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")
-- ▼直接出力
voice_play("VO_101030_sp_0001_3")
-- ▲直接出力

	--★★エレイン★★:先輩、私…どうしましょう…！
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030027")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あのときトビーをまっすぐ見て言えたか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07030028")

	PlayAction(Actor002,"to  Std_Sad01")
-- ▼直接出力
PlayPartVoice("エレイン", "肯定")
-- ▲直接出力

	--★★エレイン★★:は、はいまっすぐトビーくんを見ていたら
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★エレイン★★:悲しませたくないという思いがこみあげて思わずあんなことを言ってしまいました
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030030")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:…それなら、エレインの思いがトビーにも伝わったんじゃないかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07030031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なんにしてもトビーに嘘をついてしまったことは事実だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07030032")


	--★★ノワール★★:いつかは本当を伝えなくちゃならない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07030033")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:今日のところはいったんログレスに戻ってあらためて出直そう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101030_07030034")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("エレイン", "落胆")
-- ▲直接出力

	--★★エレイン★★:はい…
	Talk(Actor002,"CHRNAME_ELAINE","speech","L","CO_101030_07030035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
local trustParam = set_communication_rankup("エレイン_コミュランク", "エレイン_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_start()
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
setup_prop_object_preload(10106003)
tegami_offset = {0,0,0,0,0,0}
	InitializeLoad_Preload()
	load_area_scene_preload(114031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101030","001","101030001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("401017","001","401017001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("401019","001","401019001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
