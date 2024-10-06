-- このluaスクリプトは、CO_101001_0603.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110061_03","110061_03_h")
Include("content_adv_advsmall_110061_03","Template110061_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110061_03_007,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_007)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110061_03_006,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110061_03,CameraPos110061_03_006)
	InitializeTemplateRandomCamera110061_03()
	InitializeTemplate110061_03()
-- ▼直接出力
set_enable_auto_lookat(Actor001, false)
keep_ik_lookat(Actor001,Actor002,"J_Head")
lookat_weight(Actor001,0.5,0.1,0.8,0.2)
-- ▲直接出力
-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110061)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_2DOnly("101027","001","101027001")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor003,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ディンドラン", "肯定")
-- ▲直接出力
	open_cutin(1,1)
	on_cutin(1,Actor003,"Normal")

	--★★ディンドラン★★:伝記の棚はこちらです
	Talk(Actor003,"CHRNAME_DINDRANE","speech","N","CO_101001_06030002")

	close_cutin()
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力

	--★★ティルフィング★★:ありがとうございます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030003")

	open_select_window_tag(Actor001,"Normal","CO_101001_06030005","CO_101001_06030006","CO_101001_06030007")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:誰について調べるんだ？<br>やっぱり過去の偉大な王様とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030009")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:いいえ
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030010")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:かつて私とともに戦ってくれた<br>人々の名前が無いかと思いまして
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030011")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:昔のティルフィングの仲間ってことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030012")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_reset(Actor002,0.7)
wait_time(0.3)
-- ▲直接出力
	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか調べたい武器があったのか？<br>以前、キミが使っていた武器とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030014")

-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:いえ<br>そういうわけではありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030015")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:私とともに戦った………いえ<br>なんでもありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030016")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_reset(Actor002,0.7)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:（もしかして、昔に一緒に戦った<br>仲間のことを調べたいのかな？）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101001_06030018")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:キミの調べものが終わるまで<br>俺はどこかで時間を潰していようかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030020")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:はい<br>構いませんよ、マスター
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030021")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "苦しみ")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:じょ、冗談だよ冗談<br>俺も調べものに付き合うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030023")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:それで、なにを調べるんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030024")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:かつて私とともに戦ってくれた<br>人々のことです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030025")

-- ▼直接出力
set_enable_auto_lookat(Actor002, false)
lookat_delay_weight_reset(Actor002,0.7)
wait_time(0.3)
-- ▲直接出力
	goto Block1end

::Block1end::
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:………
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030027")

-- ▼直接出力
set_enable_auto_lookat(Actor002, true)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか見つかりそうか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030029")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:いいえ<br>それらしきものは、まるで遺っていません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030031")

	open_select_window_tag(Actor001,"Normal","CO_101001_06030033","CO_101001_06030034")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:そっか…残念だな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030036")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:はい…<br>でも、仕方ありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030037")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:そういうもの、ですから
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030038")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:やっぱり<br>クリスティーナさんにも聞いてみるか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030040")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なにか知っているかもしれない<br>もっと大きな図書館も紹介してくれるかも
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030041")

-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:いいえ<br>その必要はありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030042")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:お気遣い、感謝します
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030044")

	goto Block2end

::Block2end::
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:私が求める記載のある書物は無いのでしょう<br>多分…最初から
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030046")

	change_face(Actor001,"Normal")

	--★★ノワール★★:なんでそう思うんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030047")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定3")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:バルバロイは、人間の記憶を喰らいます
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ティルフィング★★:そしてその果てに待つのは
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030050")


	--★★ティルフィング★★:その者が存在したという記憶の喪失
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030051")


	--★★ティルフィング★★:ありとあらゆる人々が<br>バルバロイに喰われれば
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030052")

-- ▼直接出力
PlayPartVoice("ティルフィング", "悲しみ")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:その記憶を語れる者もいなくなる
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030053")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:それは…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030054")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:伝承も、伝記も、記録も
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030055")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ティルフィング★★:記すべきものの記憶が<br>存在しなければ作られることはない
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030056")

	change_face(Actor002,"Sad")

	--★★ティルフィング★★:消される前に記されたものが<br>あれば、あるいはと思いましたが…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030058")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "落胆")
-- ▲直接出力

	--★★ティルフィング★★:やはり私の希望的観測に<br>過ぎなかったようです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030059")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:ティルフィング<br>諦めちゃダメだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030060")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:探そう、いろんなところを<br>俺も協力するから
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030061")

	change_face(Actor002,"Anger")

	--★★ティルフィング★★:いけません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030062")


	--★★ティルフィング★★:アナタには<br>やらなければならないことがあります
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030063")

	PlayAction(Actor002,"to  Std_Talk")

	--★★ティルフィング★★:私のためにその歩みを止めることなど<br>あってはならないのです
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030064")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:けど…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030065")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:一度はこの地にはびこるバルバロイを封じた<br>それは紛れもない事実でしょう
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030067")


	--★★ティルフィング★★:ですが私は仲間たちを救うことまでは<br>できていなかったのかもしれません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030068")

-- ▼直接出力
PlayPartVoice("ティルフィング", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:私の行ったことは、果たして…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030069")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:意味があったのか、なんて言わないでくれ<br>まだ救えなかったと決まったわけじゃないだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030071")


	--★★ノワール★★:大図書院にはたまたま記録がなかっただけで<br>別の場所に残ってるかもしれない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030072")

-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:そう、ですね<br>そうであって欲しい、です…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_06030073")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:それに昔の仲間だって、ティルフィングに<br>そんな顔はして欲しくないはずだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030074")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:俺は、そう思うよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_06030076")

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
	load_area_scene_preload(110061)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_2DOnly_Preload("101027","001","101027001")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110061_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
