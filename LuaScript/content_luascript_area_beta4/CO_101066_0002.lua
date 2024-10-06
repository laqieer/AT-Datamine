-- このluaスクリプトは、CO_101066_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_112041_03","112041_03_h")
Include("content_adv_advsmall_112041_03","Template112041_03_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos112041_03_002,"content_motion3d_advarea_common_adv_templatecontroller","Chr_002_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos112041_03_003,"content_motion3d_advarea_common_adv_templatecontroller","Npc_015_01_StdController","to Std_Loop",CameraAssetBundleName112041_03,CameraPos112041_03_003)
	InitializeTemplateRandomCamera112041_03()
	InitializeTemplate112041_03()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(112041)
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
PlayPartVoiceDirect("ブレイズ","0002")
-- ▲直接出力

	--★★ブレイズ★★:まさか教師を連れて酒場に来るとは…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010008")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0001")
-- ▲直接出力

	--★★ブレイズ★★:お主、なかなか肝の据わったワルじゃのう～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010009")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0048")
-- ▲直接出力

	--★★ノワール★★:そんなつもりじゃないって
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010010")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:冗談じゃ<br>ここは食事が美味いからのう
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010011")


	--★★ブレイズ★★:それ目当てで足しげく通う女の子も多い<br>お主がここに来たくなる気持ちもわかるぞい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010012")

	change_face(Actor001,"Anger")

	--★★ノワール★★:もっとそんなつもりじゃない！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010013")

	PlayAction(Actor002,"to  Std_Talk")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:それじゃ、どんなつもりなんじゃ？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010014")

	open_select_window_tag(Actor001,"Normal","CO_101066_00010015","CO_101066_00010016","CO_101066_00010017")
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
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:俺、まだこの街にあまり詳しくなくてさ<br>食べる場所で思いついたのがここなんだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010019")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0046")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:なるほどのう～
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010020")

	PlayAction(Actor002,"to  Std_Worry")
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:確かに、この店の料理は絶品じゃし、<br>ここを選んでおけば間違いはないんじゃが…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010021")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:だが、デートにはちと不向きかもしれんなぁ…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010022")

	PlayAction(Actor001,"to  Std_Surp")
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0028")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:で、デート…！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010023")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:若者たるもの、気になる相手を誘うレストランの<br>ひとつやふたつ知っておかんとじゃろう？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010024")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:よし、それじゃ…今度お主のためにワシが<br>とっておきの店を教えてやるぞい！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010025")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0007")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あ、ああ…よろしく…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010026")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ここ、あんたの行きつけなんだろ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0039")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:うむ、そうじゃ
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010030")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0010")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:ここであんたの教え子だって顔を売っておけば<br>今後、あんたのツケで食べられるかなと思って
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010031")

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0007")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:お主、なかなか良い性格しとるのう…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010032")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:だがいいぞ<br>若者はそれくらい強かでないとな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010033")

	PlayAction(Actor002,"to  Std_Talk")
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:さて。ならば<br>ワシのイチオシのメニューを教えてやるかの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010034")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0013")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:塩がバッチシ効いてて<br>最高に美味いんじゃ！
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010035")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoiceDirect("ノワール","0040")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:いや、あんまりしょっぱくないやつにしてくれ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010036")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	PlayAction(Actor001,"to  Std_Talk")
-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:どこか落ち着いた場所で<br>じっくり先生と話がしたかったんだよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010039")

	change_face(Actor001,"Normal")

	--★★ノワール★★:バルバロイのこととか<br>オブリヴィエのことか
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010040")

	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0010")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:ふぉっふぉ！<br>感心感心、殊勝な心掛けじゃの
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010041")

	PlayAction(Actor002,"to  Std_Sad01")
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:じゃが…
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010042")

-- ▼直接出力
setup_small_camera_start(RndCamera006)
se_play("SE_ambient_bar")
-- ▲直接出力
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0019")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ブレイズ★★:ここでじっくり話ができると思うかの？
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010043")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0025")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:…無理っぽいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010044")

-- ▼直接出力
PlayPartVoiceDirect("ノワール","0037")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ごめん！<br>俺、その手の話ができる店とか知らなくて…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010045")

-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0038")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ブレイズ★★:気にせんでよい<br>そのへんの話はいつでもできるじゃろうしな
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010046")

-- ▼直接出力
setup_small_camera_end(RndCamera006)
se_play("SE_LoopSE_Stop")
-- ▲直接出力
	PlayAction(Actor002,"to  Std_Joy")
-- ▼直接出力
PlayPartVoiceDirect("ブレイズ","0013")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ブレイズ★★:そんなことより、せっかく誘ってもらったんじゃ<br>今日はうんと食わせてもらうぞい
	Talk(Actor002,"CHRNAME_BLAZE","speech","L","CO_101066_00010047")

	change_face(Actor001,"Sad")

	--★★ノワール★★:お、お手柔らかに…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101066_00010048")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ブレイズ")
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
	load_area_scene_preload(112041)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101066","001","101066001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName112041_03)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
