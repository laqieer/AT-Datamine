-- このluaスクリプトは、MA_01106_11.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_111031_01","111031_01_h")
Include("content_adv_advsmall_111031_01","Template111031_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos111031_01_002,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_002)
	Camera002 = SetTemplate("Actor002",nil,CharaPos111031_01_009,"content_motion3d_advarea_common_adv_templatecontroller","Chr_004_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_009)
	Camera003 = SetTemplate("Actor003",nil,CharaPos111031_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Npc_503_01_StdController","to Std_Loop",CameraAssetBundleName111031_01,CameraPos111031_01_004)
	InitializeTemplateRandomCamera111031_01()
	InitializeTemplate111031_01()
-- ▼直接出力
off_active(Actor002)
load_image("101010150", "content_still_10101015_image", "101010150_StillImage")
-- ▲直接出力
-- ▼直接出力
load_image("101010270", "content_still_10101027_image", "101010270_StillImage")
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(111031)
	Actor001 = InitializeCharacter_3D("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_2DOnly("101060","001","101060001")
	template1()
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()


	--★★モルガン★★:冷めないお茶がね<br>あればいいのだけれど
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110002")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★モルガン★★:熱いうちに、どうぞ？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110004")

	open_select_window_tag(Actor001,"Normal","MA_01106_110006","MA_01106_110007","MA_01106_110008")
	if is_select(1) then
		goto Block1_1
	elseif is_select(2) then
		goto Block1_2
	elseif is_select(3) then
		goto Block1_3
	end

::Block1_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:い、いただきます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110010")

	change_face(Actor003,"Normal")

	--★★モルガン★★:…ありがとう。ノワールくん
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110012")

	change_face(Actor003,"Normal")

	--★★モルガン★★:どんなにきれいな水があってもね<br>新鮮な葉がとれてもね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110013")

	change_face(Actor003,"Normal")

	--★★モルガン★★:手際よく淹れられたとしてもね<br>ひとりだとあまり…良くないのね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110014")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★モルガン★★:誰かと飲むほうがおいしいの<br>付き合ってくれて嬉しいわ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110015")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:猫舌なので…<br>もう少ししてからいただきます
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110017")

	change_face(Actor003,"Surprise")

	--★★モルガン★★:体質なら仕様がないわね<br>少し残念だけれど
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110018")

	change_face(Actor003,"Normal")

	--★★モルガン★★:冷めてもおいしいお茶…<br>探しておくわね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110019")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★モルガン★★:ノワールくんのために♪
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110020")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:なんの用ですか？<br>引き払いの手伝いならいくらでもできますが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110022")

	change_face(Actor003,"Sad")

	--★★モルガン★★:もお、せっかち
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110023")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Sad")

	--★★モルガン★★:生徒のことを知りたいと思うのは<br>療養院の先生としておかしいことかしら？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110024")

	goto Block1end

::Block1end::
	change_face(Actor003,"Normal")

	--★★モルガン★★:宵越しのお茶は良くないとも言うわね<br>だけど私、それはもったいないと思うの
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110026")

	change_face(Actor003,"Smile")

	--★★モルガン★★:できることならずぅっとずぅーっと<br>おいしくいて欲しいとは思わない？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110027")

	open_select_window_tag(Actor001,"Normal","MA_01106_110029","MA_01106_110030")
	if is_select(1) then
		goto Block2_1
	elseif is_select(2) then
		goto Block2_2
	end

::Block2_1::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:そのときにしか出ないおいしさがある<br>とも思いますが…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110032")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★モルガン★★:同感ね。だからこそ淹れかたが工夫されたり<br>旬があったりするのだものね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110034")

	change_face(Actor003,"Smile")

	--★★モルガン★★:ノワールくん、意外とお茶好き？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110036")

	goto Block2end

::Block2_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Smile")

	--★★ノワール★★:最高のおいしさがずっと続くなら<br>理想的ですね
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110038")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★モルガン★★:そうよね、そう思うわよね！ノワールくんも！
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110039")

	change_face(Actor003,"Normal")

	--★★モルガン★★:せっかくおいしく淹れられても<br>ちょっと経ったら風味が失われてしまったり
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110040")

	change_face(Actor003,"Sad")

	--★★モルガン★★:ほんとうに、やんなっちゃうわよね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110041")

	goto Block2end

::Block2end::
-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:………ねえノワールくん
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110043")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:はい？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110044")


	--★★モルガン★★:…貴方もゲシュタルト・シフト<br>するのかなあ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110046")


	--★★ノワール★★:どう…なんでしょうか<br>ティルフィングもいてくれますし…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110047")


	--★★モルガン★★:あの子は貴方がＧＳした子ではないんでしょう？<br>この話は学園内ではヒミツらしいけれど
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110048")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)

	--★★ノワール★★:…はい
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110050")

	change_face(Actor003,"Sad")

	--★★モルガン★★:人には原罪が受け継がれていると言うわ<br>『真実』を手に入れてしまった咎が
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110051")

	change_face(Actor003,"Normal")

	--★★モルガン★★:食せば死す果実を『始まりの人』が口にし<br>善悪の知識を得た代わりに楽園から追放された
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110052")


	--★★モルガン★★:ノワールくんは、どう？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110053")


	--★★モルガン★★:そんなふうに『本当』を得られるのなら<br>代償をともなっても構わないと思う？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110054")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","MA_01106_110056","MA_01106_110057","MA_01106_110058")
	if is_select(1) then
		goto Block3_1
	elseif is_select(2) then
		goto Block3_2
	elseif is_select(3) then
		goto Block3_3
	end

::Block3_1::
	CloseTalkWindow()
	change_face(Actor001,"Surprise")

	--★★ノワール★★:モルガン先生…？<br>どうして突然そんなことを…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110060")

-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor002)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:どうしてかしらね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110061")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★モルガン★★:聞きたくなってしまったのよ、突然ね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110062")

	goto Block3end

::Block3_2::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Normal")

	--★★ノワール★★:…どんな代償をともなっても<br>『本当』のことを知りたいです
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110064")

	change_face(Actor003,"Normal")

	--★★モルガン★★:アーサーから聞いたわ<br>ランスロットとのこと…それほど大切なのね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110065")

-- ▼直接出力
setup_small_camera_start(Camera001)
Appear(Actor002)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:ディナタンのためでもあります<br>知らないままでいさせるのはあまりにも酷だ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110066")

	goto Block3end

::Block3_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Sad")

	--★★ノワール★★:…失う代償による、と思います
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110068")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
setup_small_camera_start(Camera003)
Appear(Actor002)
keep_ik_lookat(Actor002,Actor001,"J_Head")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★モルガン★★:そうよねえ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110069")

	change_face(Actor003,"Normal")

	--★★モルガン★★:貴方はまだ若いわ<br>じっくり考えて決めてちょうだいね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110070")

	goto Block3end

::Block3end::
-- ▼直接出力
DontChangeRandomCamera(true)
on_camera(Camera002)
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:…父の死の真相を追わなければ、楽でしょうけど<br>それでも、ランスロットに妹を救われて
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110072")


	--★★ノワール★★:ギネヴィアやガウェインたちと一緒に戦って<br>これからも誰かが戦い続けるのに
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110073")


	--★★ノワール★★:本当は戦える力があるのに、家族を守れるのに<br>知らないふりをするなんてできません
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110074")

-- ▼直接出力
setup_small_camera_start(Camera003)
Hide(Actor002)
-- ▲直接出力
	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Normal")

	--★★モルガン★★:うん。そうよね
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110076")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力

	--★★モルガン★★:わたしはうまく動けないから
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110077")


	--★★モルガン★★:些細なことでしか<br>学園の子たちの力になれないけど
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110078")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)

	--★★モルガン★★:でも、そんな顔させたくない
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110079")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:…モルガン、先生？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110080")


	--★★モルガン★★:抗うすべ、選び抜く道、その先の平和に…<br>ノワールくん──貴方の武器が要るわ
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110081")

-- ▼直接出力
bgm_play("Set_BGM_Bus_LPF_Volume_2")
CloseTalkWindow()
fadeout(255,255,255,1.0, 0.5)
wait_time(0.5)
show_image("101010270", 0.0, 0.0, 0.0,true,true)
on_cameraframe(2)
on_screencolor(IMAGE_COLOR, 0, -50)
 --フェードイン
fadein(0.5)
wait_time(0.5)
-- ▲直接出力

	--★★セレスティ★★:だけど忘れないで<br>父さんが全部遺してくれたから
	Talk(Actor004,"NPCNAME_0163","simple","N","MA_01106_110083")


	--★★セレスティ★★:抗うすべも、選び抜く道も、その先の平和も
	Talk(Actor004,"NPCNAME_0163","simple","N","MA_01106_110085")

-- ▼直接出力
bgm_play("Reset_BGM_Bus_LPF_Volume_2")
CloseTalkWindow()
fadeout(255,255,255,1.0, 0.5)
wait_time(0.5)
hide_image(0)
off_cameraframe()
off_screencolor()
 --フェードイン
fadein(0.5)
wait_time(0.5)
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★モルガン★★:ふんばろうねっ<br>どんなに辛いことがあっても
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110087")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力

	--★★ノワール★★:…母さん──…？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110089")

	change_face(Actor003,"Surprise")

	--★★モルガン★★:え！ええっ、何ノワールくん…！ふふーッ<br>先生を母さんって呼んじゃう系？ええ～
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110090")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)

	--★★ノワール★★:あ、ああ、いえ…、すみません…！
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01106_110091")

	change_face(Actor003,"Normal")

	--★★モルガン★★:そうだっ。落ち着いたのなら<br>みんなと一緒にリンゴ狩りに行って来たら？
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110093")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
	change_face(Actor003,"Smile")

	--★★モルガン★★:ありがとう<br>茶番に付き合ってくれて
	Talk(Actor003,"CHRNAME_MORGAN","speech","L","MA_01106_110094")

	open_select_window_tag(Actor001,"Normal","MA_01106_110096","MA_01106_110097","MA_01106_110098")
	if is_select(1) then
		goto Block4_1
	elseif is_select(2) then
		goto Block4_2
	elseif is_select(3) then
		goto Block4_3
	end

::Block4_1::
	CloseTalkWindow()
	goto Block4end

::Block4_2::
	CloseTalkWindow()
	goto Block4end

::Block4_3::
	CloseTalkWindow()
	goto Block4end

::Block4end::
	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
load_image_preload("101010150", "content_still_10101015_image", "101010150_StillImage")
load_image_preload("101010270", "content_still_10101027_image", "101010270_StillImage")
	InitializeLoad_Preload()
	load_area_scene_preload(111031)
	InitializeCharacter_3D_Preload("101009","001","101009001","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101014","001","101014001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101041","003","101041003","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_2DOnly_Preload("101060","001","101060001")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName111031_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
