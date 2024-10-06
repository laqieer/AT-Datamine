-- このluaスクリプトは、CO_101063_0402.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114071_01","114071_01_h")
Include("content_adv_advsmall_114071_01","Template114071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",210,CharaPos114071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_004)
	Camera002 = SetTemplate("Actor002",130,CharaPos114071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_013_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_003)
	InitializeTemplateRandomCamera114071_01()
	InitializeTemplate114071_01()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor001,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.8,0.2)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★クリスティーナ★★:今日はとっておきのコスメグッズを<br>たくさん持ってきたわ～
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020002")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:シャンプー、コンディショナーにボディーソープ<br>洗顔料にオイル…これで綺麗になりましょっ！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020003")

	open_select_window_tag(Actor001,"Normal","CO_101063_04020005","CO_101063_04020006")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:全身ピカピカになれそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020008")

	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:見えないトコまでピカピカよ♪
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020009")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:香りもとってもいいから<br>リピりたくなること間違いなし！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020010")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:高そうな美容品ばっかりじゃないか？<br>そこまでしてもらうのは悪いよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020012")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:遠慮しないで♪<br>いつも手伝ってくれるお礼よ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020013")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:それに、ノワールちゃんにはいつも<br>みずみずしいカラダでいて欲しいし
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020014")

	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ノワールちゃんを私と同じにおいにできる<br>またとないチャンス…！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020015")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:や、やっぱり帰ろうかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020016")

	goto Block1end

::Block1end::
	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:てことで、今回は特別に<br>クリスティーナスペシャルコースにご招待！
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020018")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:にゅ、入門コースからでいいよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020019")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:さ、力を抜いて<br>私に全部委ねてちょうだ～い?
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020021")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
SkipDefaultMotion(Actor001)
PlayPartVoiceDirect("ノワール","0031")
-- ▲直接出力

	--★★ノワール★★:ちょ、ちょっと…<br>う、うわあああああ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020022")

-- ▼直接出力
 --暗転して時間経過
CloseTalkWindow()
fadeout(0,0,0,1.0, FADE_TIME)
wait_time(TIME_ELAPSED + FADE_TIME)
setup_small_camera_start()
set_battlecontroller(Actor001,"fig_axe","AC_TL_Fig_Axe_Idle_Run","ToAbnormal")
wait_time(1.0)
fadein(FADE_TIME)
wait_time(FADE_TIME)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★クリスティーナ★★:はい、お疲れさま?
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020024")

-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:確かにスペシャルなコースだった…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020025")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_start(Camera002)
PlayPartVoiceDirect("クリスティーナ","0010")
set_animationcontroller(Actor001, "Chr_002_01_StdController", "to Std_Loop")
wait_time(2)
setup_small_camera_end(Camera002)
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:でも…確かに肌の触り心地が全然違う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020027")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:赤ちゃんみたいな肌触りになったわねお化粧のノリもぐっと良くなるのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020028")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力

	--★★ノワール★★:顔を洗うなんて水しか使ってなかったけどこんなに違いがあるもんなんだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020029")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:でっしょ～！？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020031")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:今の私があるのは美容品のおかげ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020032")


	--★★クリスティーナ★★:コスメは容姿や性格に関係なく全員を美の高みへと押し上げてくれるの
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020033")

	PlayAction(Actor002,"to  Std_Talk")

	--★★クリスティーナ★★:このコたちがいるから私は毎日胸を張って生きていける
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020034")


	--★★クリスティーナ★★:みんなに受け入れてもらえてるって実感できているのよ
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020035")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101063_04020037","CO_101063_04020038","CO_101063_04020039")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	elseif is_select(3) then
		goto Block2_3
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:素敵なものなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020041")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:そうよ～。ノワールちゃんにも魅力が伝わったかしら?
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここまでやってもらったし少しはね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020043")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:美容品のおかげだけじゃないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020045")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:クリスさんがみんなから慕われてるのはそもそもの人柄によるものだと思う
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020046")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("クリスティーナ","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ありがとう周りの人や環境に恵まれてるのは確かね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020047")

	goto Block2end

::Block2_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:こういった美容の知識は本から学んだのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020049")

-- ▼直接出力
PlayPartVoice("クリスティーナ", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:そうね、それもあるけど
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020050")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:私の探求心のたまもの！…というのが正しいかも
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020051")

	goto Block2end

::Block2end::
-- ▼直接出力
PlayPartVoice("クリスティーナ", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★クリスティーナ★★:でも…どんなに高価な美容品でも取り繕えるのは上面だけなのかもしれない
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020053")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Sad02")

	--★★クリスティーナ★★:隠したい、隠さなきゃって思うほどに化粧は厚くなっていって
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020055")


	--★★クリスティーナ★★:内面の汚れに気づきにくくなる
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020056")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)

	--★★クリスティーナ★★:化粧がはがれ落ちた私を見て周りのみんなはどう思うのかしら？
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020057")

	change_face(Actor001,"Normal")

	--★★ノワール★★:変わらないよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020058")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:化粧をしていてもしていなくてもクリスさんはクリスさんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020059")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("クリスティーナ","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★クリスティーナ★★:ふふ、ありがとさすがノワールちゃん、優しいわね
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020060")

	change_face(Actor002,"Normal")

	--★★クリスティーナ★★:本当に私の王子様、なのかも
	Talk(Actor002,"CHRNAME_CHRISTINA","speech","L","CO_101063_04020061")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは、違う………
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101063_04020062")

-- ▼直接出力
local trustParam = set_communication_rankup("クリスティーナ_コミュランク", "クリスティーナ_親密度")
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
	load_area_scene_preload(114071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101063","001","101063001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
