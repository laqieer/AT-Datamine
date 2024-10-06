-- このluaスクリプトは、CO_101039_0903.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110171_02","110171_02_h")
Include("content_adv_advsmall_110171_02","Template110171_02_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110171_02_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110171_02,CameraPos110171_02_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110171_02_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_514_01_StdController","to Std_Loop",CameraAssetBundleName110171_02,CameraPos110171_02_005)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110171_02_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_020_01_StdController","to Std_Loop",CameraAssetBundleName110171_02,CameraPos110171_02_002)
	InitializeTemplateRandomCamera110171_02()
	InitializeTemplate110171_02()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor003,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.7,0.6)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
keep_ik_lookat(Actor002,Actor003,"J_Head")
lookat_weight(Actor002,0.5,0.1,0.7,0.6)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110171)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:…というわけなんだ
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030002")


	--★★フレン★★:約束は果たしたでしょ？<br>だから競技大会の準備を…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030003")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:競技大会の準備なら済んでいる
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Surp")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09030005")

-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定2")
-- ▲直接出力

	--★★ルーシャス★★:聞こえなかったのか？<br>諸々の準備ならすべて済ませてある
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030006")

	PlayAction(Actor002,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("フレン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:え、だって…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030007")

	PlayAction(Actor003,"to  Std_Talk")

	--★★ルーシャス★★:余がやらなければならないこと<br>そう言ったのは、そなたらだろう
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030009")


	--★★ルーシャス★★:ならば速やかに済ませるさ<br>何度も教えたではないか
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030010")


	--★★ルーシャス★★:余は「時の浪費」が嫌いなのだ
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ルーシャス", "肯定")
-- ▲直接出力

	--★★ルーシャス★★:開催日は好きにするが良い<br>賞品も決まったら連絡しろ。揃えてやる
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030013")


	--★★ルーシャス★★:ああ、それから…<br>当日までにあれも戻ってこられるだろう
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030014")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ルーシャス★★:ヴェルナルスのキズが癒えるまでの<br>退屈凌ぎにでもなればと思っていたが
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030016")

-- ▼直接出力
if is_active(RndCamera090) == false then
DontChangeRandomCamera(true)
on_camera(Camera003)
end
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ルーシャス", "笑い")
-- ▲直接出力

	--★★ルーシャス★★:なかなかどうして<br>面白い見世物であったよ<br>
	Talk(Actor003,"CHRNAME_LUCIUS","speech","L","CO_101039_09030017")

-- ▼直接出力
 --フェードアウト
CloseTalkWindow()
fadeout(0,0,0,1.0, CHARA_IN_IN)
wait_time(CHARA_IN_IN + CHARA_IN_WAIT)
Hide(Actor003)
setup_small_camera_start()
--フェードイン
fadein(CHARA_IN_OUT)
wait_time(CHARA_IN_OUT + FADE_AFTER_TIME)
-- ▲直接出力
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101039_09030019","CO_101039_09030020")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…なんだ、あれ？<br>俺たちをからかってたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09030022")

	change_face(Actor002,"Normal")

	--★★フレン★★:ううん、あれがルーシャスくんなりの<br>思いやりなんじゃないかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:ほんと、素直じゃないんだから
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030024")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:まったく…素直じゃないな、相変わらず
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09030026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★フレン★★:ほんとほんと！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030027")

-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:私たちをからかってくれたお返しに<br>うーんと高い賞品を用意させてやるんだ！
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030028")

	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★フレン★★:それにしても…<br>ルーシャスくん、見てたのかな？
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030030")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor001,Actor002,"J_Head",1.0)
wait_time(0.3)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:さっきの陸上部でのやりとりのこと？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101039_09030031")

-- ▼直接出力
CloseTalkWindow()
keep_delay_ik_lookat(Actor002,Actor001,"J_Head",1.0)
wait_time(0.4)
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("フレン", "肯定2")
-- ▲直接出力

	--★★フレン★★:うん<br>だったら…
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030032")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
wait_time(0.3)
lookat_delay_weight_reset(Actor002,0.6)
wait_time(0.8)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("フレン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★フレン★★:伝わるといいな、ルーシャスくんにも
	Talk(Actor002,"CHRNAME_FREN","speech","L","CO_101039_09030033")

-- ▼直接出力
local trustParam = set_communication_rankup("フレン_コミュランク", "フレン_親密度")
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
	load_area_scene_preload(110171)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101039","001","101039001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101051","001","101051001","content_animationpack__common","FacialPack","Actor003")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110171_02)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
