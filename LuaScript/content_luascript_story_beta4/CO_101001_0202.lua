-- このluaスクリプトは、CO_101001_0202.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110071_04","110071_04_h")
Include("content_adv_advsmall_110071_04","Template110071_04_h")
-- ▼直接出力
MobsNo = 0
-- ▲直接出力
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110071_04_005,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_005)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110071_04_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_521_01_StdController","to Std_Loop",CameraAssetBundleName110071_04,CameraPos110071_04_002)
	InitializeTemplateRandomCamera110071_04()
	InitializeTemplate110071_04()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110071)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力

	--★★ティルフィング★★:それで、マスター<br>私に提案というのは、いったいどのような？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020002")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力

	--★★ノワール★★:ティルフィング、言ってたよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020003")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★ノワール★★:もう自分のことを<br>覚えている人間なんていないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020004")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:ずっとひとりでいるって<br>すごく寂しいことだと思うんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020006")

-- ▼直接出力
PlayPartVoice("ティルフィング", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:それは…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020007")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:ですが、もしそうだとしても<br>マスターが気になさる必要はありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020009")

-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…気になるよ<br>あんなとこ、見ちゃったし
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020011")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:え？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020012")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Surprise")

	--★★ノワール★★:いや、なんでもない<br>ともかく、話だけでも聞いてみてくれないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020013")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:…わかりました<br>マスターがそうおっしゃるのなら
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020014")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ありがとう<br>まぁ、そんな大した提案じゃないんだけど…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020015")

	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:せっかく学園に入ったんだし<br>もっと学園生活を楽しんでみないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020016")


	--★★ティルフィング★★:学園生活を…？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020017")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力

	--★★ノワール★★:ああ。アーサーの言葉を借りるなら<br>「青春を謳歌する」って感じかな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:俺と一緒にいろんなところに行って<br>いろんな人と交流しよう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020019")

-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうしたら、みんな<br>ティルフィングのことを覚えてくれるだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020020")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Talk")

	--★★ノワール★★:もう覚えている人がいないなら<br>また覚えてもらえばいいと思うんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020021")

-- ▼直接出力
PlayPartVoice("ティルフィング", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:私を、また覚えてもらう…？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020022")

	change_face(Actor001,"Normal")

	--★★ノワール★★:イヤかな？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020024")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "否定")
-- ▲直接出力

	--★★ティルフィング★★:い、いえ<br>そういうわけではありません
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020025")

-- ▼直接出力
PlayPartVoice("ティルフィング", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ティルフィング★★:ただ、学園生活を楽しむといっても<br>どのようなことをしたらよいものかと
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020026")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101001_02020028","CO_101001_02020029","CO_101001_02020030")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:一緒に授業の課題をやるとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020032")

-- ▼直接出力
PlayPartVoice("ティルフィング", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:授業の課題？<br>それは楽しいものなのでしょうか
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020033")

	change_face(Actor001,"Normal")

	--★★ノワール★★:せっかくの学園生活なんだしさ<br>そういうのも思い出になるだろ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020034")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:一緒に街に出て買い食いするとか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020036")

-- ▼直接出力
PlayPartVoice("ティルフィング", "挨拶")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ティルフィング★★:買い食いというのは<br>どのようなものなのでしょう？
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020037")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:やったことないか？<br>食べ物を買って、その場で食べるんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020038")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:やっぱり出来立てが一番うまいし<br>みんなでシェアしたりするのも楽しいぞ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020039")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:思いつくことをやってみよう<br>ぜーんぶ、さ！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020041")

	change_face(Actor001,"Smile")

	--★★ノワール★★:同じ風景眺めたり、共同作業したり<br>一緒になって大騒ぎしたりさ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020042")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "喜び")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:そうやって、ティルフィングと<br>みんなの楽しい思い出をたくさん作ろう
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020044")

	change_face(Actor002,"Surprise")

	--★★ティルフィング★★:私と、みなさんの思い出…
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020046")

	goto Block1end

::Block1end::
	PlayAction(Actor001,"to  Std_Talk")
	change_face(Actor001,"Normal")

	--★★ノワール★★:どうだ？<br>やってみないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101001_02020048")

	change_face(Actor002,"Normal")

	--★★ティルフィング★★:そう、ですね
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ティルフィング", "肯定")
-- ▲直接出力

	--★★ティルフィング★★:マスターのご命令であれば
	Talk(Actor002,"CHRNAME_TYRFING","speech","L","CO_101001_02020051")

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
	load_area_scene_preload(110071)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101001","001","101001001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110071_04)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
