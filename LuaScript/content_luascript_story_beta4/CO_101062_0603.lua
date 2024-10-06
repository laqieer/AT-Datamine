-- このluaスクリプトは、CO_101062_0603.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_114071_01","114071_01_h")
Include("content_adv_advsmall_114071_01","Template114071_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos114071_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_004)
	Camera002 = SetTemplate("Actor002",nil,CharaPos114071_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_012_01_StdController","to Std_Loop",CameraAssetBundleName114071_01,CameraPos114071_01_003)
	InitializeTemplateRandomCamera114071_01()
	InitializeTemplate114071_01()
-- ▼直接出力
load_image("101010140", "content_still_10101014_image", "101010140_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(114071)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:いやあ、いいお湯でしたねぇ稀少素材ゲット後のお湯は格別です～
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030002")

	PlayAction(Actor001,"to  Std_Sad02")
-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Pain")

	--★★ノワール★★:か、体がバキバキで動かない…筋肉の節々が悲鳴を上げている…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力

	--★★マルイル★★:確かにちょっと大変な道のりでしたけどその甲斐は充分にありましたね！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030004")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101062_06030006","CO_101062_06030007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ちょっとじゃなくて、かなり大変な道のりだったけどな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030009")

	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Surprise")

	--★★ノワール★★:あんた、何度も崖から落ちそうになってたろ忘れたのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030010")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoice("マルイル", "納得")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:あー、ありましたね。仕入れが上手くいくと苦労が全部吹き飛んじゃうので、忘れてました！
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030011")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あんたは大丈夫なのか？いくら鍛えてるとはいえさすがに今回はハードだっただろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030013")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ぜんぜんですよ。危なくなったときもノワールさんが助けてくれましたから
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030014")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:なら、よかったけど…あいだだだっ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:自分がそんな状態なのに、人のことを心配できるのがノワールさんの美徳ですよね
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030016")

	goto Block1end

::Block1end::
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ところでそれ、そんなに価値のあるものなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030018")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:ええ、ぼくの調べたところによればバルバロイへの対抗手段にもなるはずです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030019")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "納得")
-- ▲直接出力

	--★★ノワール★★:バルバロイの遺骸を糧にとか言ってたな結構貴重な素材ではありそうだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030020")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("マルイル", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:ノワールさんのおかげですよ～！お礼にぼく、マッサージしましょうか
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030021")

	change_face(Actor002,"Normal")

	--★★マルイル★★:ぼくのマッサージはすごいですよ全身の疲れが一発で吹っ飛ぶと評判なんです
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030022")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:へえ。ならお願いしようか体がバキバキだし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030023")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("マルイル", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★マルイル★★:承知しました！それじゃ、歯を食いしばってくださいね～
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "照れ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:え、歯を食いしばるって、なんで――
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101062_06030025")

-- ▼直接出力
CloseTalkWindow()
show_image("101010140", 0, 0, BLACK_WHITE_TIME,FALSE,FALSE)
set_scale_image(20,20)
se_play("SE_ADV_CO_101062_0602_Massage_Bakibaki")
wait_time(BLACK_WHITE_TIME + 0.5)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor001,"Pain")
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力

	--★★ノワール★★:ぐああああ！？…ああああ、あ………
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101062_06030027")

	close_cutin()
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★マルイル★★:あれっ？ノワールさん？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030028")

-- ▼直接出力
PlayPartVoice("マルイル", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★マルイル★★:ノワールさん…ノワールさんっ！？
	Talk(Actor002,"CHRNAME_MARIL","speech","L","CO_101062_06030029")

-- ▼直接出力
local trustParam = set_communication_rankup("マルイル_コミュランク", "マルイル_親密度")
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
load_image_preload("101010140", "content_still_10101014_image", "101010140_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(114071)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101062","001","101062001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName114071_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
