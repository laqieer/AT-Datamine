-- このluaスクリプトは、CO_101066_1002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110151_01","110151_01_h")
Include("content_adv_advsmall_110151_01","Template110151_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110151_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_004)
	Camera002 = SetTemplate("Actor002",-75,CharaPos110151_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName110151_01,CameraPos110151_01_002)
	InitializeTemplateRandomCamera110151_01()
	InitializeTemplate110151_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110151)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:どうじゃ、この髭！<br>ばっちりじゃろ～！？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020002")

	open_select_window_tag(Actor001,"Normal","CO_101066_10020004","CO_101066_10020005")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	end

::Block1_1::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_No")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ごめん<br>俺にはちょっとよくわからない
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020007")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0029")
-- ▲直接出力
	change_face(Actor002,"Anger")

	--★★ブレイズ★★:なんでじゃ～！よく見い！<br>この間のボッサボサ髭とはえらい違いじゃろ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020008")

	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0034")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:うーん…言われてみれば確かに<br>このあいだよりも整えられてるような…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020009")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:確かに、バッチリだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020011")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0013")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:そうじゃろう、イカしてるじゃろ～？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020012")

	change_face(Actor001,"Smile")

	--★★ノワール★★:（本当は違いなんか、わかんないけどな）
	Talk(Actor001,"CHRNAME_NOIR","mind","L","CO_101066_10020013")

	goto Block1end

::Block1end::
-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:おぬしがワシの髭を気にしておったと<br>マーリンに聞いてのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020015")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:これはバッチリ絶好調のお髭を<br>見せてやらにゃと思ったんじゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020016")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:別に、髭を気にしてたわけじゃ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020017")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0039")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:もちろん、わかっておるとも<br>ワシのことを気にかけてくれてたんじゃろ？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020018")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ブレイズ★★:おぬしのおかげで<br>しばらく前から進めておった研究が一歩前進した
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020019")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0036")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:感謝しておるぞ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020020")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:完成しそうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020021")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:気が早いのう<br>一歩前進しただけじゃ。先はまだ長い
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020022")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0015")
-- ▲直接出力

	--★★ブレイズ★★:ここから先へ進めるためには<br>おぬしたちの戦いを観察することが重要になる
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020023")

	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0045")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:そういうものなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020024")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0013")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:うむ。おぬしたちがどのような道を選び<br>どう行動していくか…見せてもらうとしようかの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020025")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	PlayAction(Actor001,"to  Std_Worry")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0008")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:そうか。俺にはよくわからないけど…<br>あんたに観察されてると思うと気が抜けないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020026")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力

	--★★ブレイズ★★:ふぉっふぉっふぉ、せいぜい気張ることじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020027")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0028")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ブレイズ★★:あ！とはいえ、新種のバルバロイに<br>遭遇したら真っ先にワシに教えるんじゃぞ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020028")

	change_face(Actor002,"Anger")

	--★★ブレイズ★★:オブリヴィエの調査も<br>忘れずに逐一報告するように！逐一じゃぞ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020029")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力

	--★★ノワール★★:ああ、任せてくれ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020030")

-- ▼直接出力
setup_small_camera_start(RndCamera005)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:さて…それじゃ、研究に協力してくれた礼に<br>おぬしにとっておきのご褒美をやろうかのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020031")

	change_face(Actor001,"Normal")

	--★★ノワール★★:ご褒美？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020032")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ふぉっふぉっふぉ…とっておきじゃぞ～？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020033")

	PlayAction(Actor002,"to  Std_Talk")
	open_cutin(1,1)
	on_cutin(1,Actor002,"Smile")

	--★★ブレイズ★★:じゃじゃーん！ワシの愛情とお塩がたっぷり<br>ブレイズ先生特製、手作り塩クッキーじゃ～！！
	Talk(Actor002,"CHRNAME_BLAZE","speech","N","CO_101066_10020034")

	close_cutin()
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0030")
PlayActionDirect(Actor001,"to  Std_Surp")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:げっ…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_10020035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0013")
-- ▲直接出力

	--★★ブレイズ★★:市販のものより塩分強めじゃからのう～<br>もっともっと脳にビシビシくるぞい！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_10020036")

-- ▼直接出力
setup_small_camera_start(RndCamera009)
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0011")
-- ▲直接出力
	open_cutin(2,2)
	on_cutin(1,Actor002,"Smile")
	on_cutin(2,Actor001,"Surprise")

	--★★ブレイズ★★:さぁ、ノワール！これを食べて<br>バルバロイとの戦いを乗り切るんじゃ～
	Talk(Actor002,"CHRNAME_BLAZE","speech","N","CO_101066_10020037")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0031")
PlayActionDirect(Actor001,"to  Std_Surp")
SkipDefaultMotion(Actor001)
-- ▲直接出力

	--★★ノワール★★:か、勘弁してくれ～！
	Talk(Actor001,"CHRNAME_NOIR","speech","N","CO_101066_10020038")

-- ▼直接出力
CloseTalkWindow()
-- ▲直接出力
	close_cutin()
-- ▼直接出力
local trustParam = set_communication_rankup("ブレイズ_コミュランク", "ブレイズ_親密度")
-- ▲直接出力
-- ▼直接出力
trustParam.UpdateRankup() -- ここまでの上昇値をゲージの変化量に変換
-- ▲直接出力
-- ▼直接出力
open_trust_rank_up(Actor002, trustParam)
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
	load_area_scene_preload(110151)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110151_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
