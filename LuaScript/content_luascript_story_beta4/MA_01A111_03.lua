-- このluaスクリプトは、MA_01A111_03.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_008,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_008)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_006,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_006)
	Camera003 = SetTemplate("Actor003",nil,CharaPos110122_01_007,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_007)
	Camera004 = SetTemplate("Actor004",nil,CharaPos110122_01_005,"content_motion3d_advarea_common_adv_templatecontroller","Com_f_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_005)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
-- ▼直接出力
keep_ik_lookat(Actor001,Actor002,"J_Head")
keep_ik_lookat(Actor002,Actor001,"J_Head")
keep_ik_lookat(Actor003,Actor002,"J_Head")
keep_ik_lookat(Actor004,Actor002,"J_Head")
-- ▲直接出力
-- ▼直接出力
 lookAtWeight = {0.4, 0.08, 0.7, 0.6}
-- ▲直接出力
-- ▼直接出力
setup_template_moveobj_110122_01(3,false)
setup_template_moveobj_110122_01(4,false)
-- ▲直接出力
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	Actor003 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	Actor004 = InitializeCharacter_3D("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor003,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力

	--★★ギネヴィア★★:差出人の名前が書いてないのよね<br>この恋文
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030002")

-- ▼直接出力
 --PlayPartVoice("ノワール", "落胆")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:驚かせないでくれ…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_030003")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)

	--★★ギネヴィア★★:毎朝お姉ちゃんがね<br>わたしの机をチェックしてくれてるのよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030004")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わたしは要らないって言ってるんだけどね<br>もと王妃って立場上不審物とかあったら怖いしね
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030005")

	change_face(Actor002,"Normal")

	--★★ギネヴィア★★:で、まあ、そしたら恋文が入ってたんだって
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030006")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "納得")
-- ▲直接出力
	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:いやマジ話聞いただけだったら<br>ギネヴィア様のお姉さんからの恋文かと思ったわ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_030007")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "納得")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:それはそれで興味がわくけど違うんだねー<br>ほんと、びっくりした
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030008")

-- ▼直接出力
CloseTalkWindow()
setup_small_camera_end()
wait_time(1.0)
-- ▲直接出力
	open_cutin(1,2)
	on_cutin(1,Actor004,"Anger")

	--★★ラグネル★★:違う違う違う違う違う違う<br>違うよガウェイン！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","N","MA_01A111_030010")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	close_cutin()
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:味わってんだよ今<br>なんだよ食ってんだよ今
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_030011")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力

	--★★ラグネル★★:誰かからギネヴィア様への恋文ってことでしょ！<br>ギネヴィア様に想いを寄せる人がいるんだよ！？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030012")

	change_face(Actor003,"Surprise")

	--★★ガウェイン★★:だから？
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_030013")

	play_head_motion(Actor004, "Nod", 0.3, 1.0, false)

	--★★ラグネル★★:ドキドキでしょうが！！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030015")

	open_select_window_tag(Actor001,"Normal","MA_01A111_030016","MA_01A111_030017","MA_01A111_030018")
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
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:ドキドキだな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_030020")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ギネヴィア★★:ほんとお？
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030021")

-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:気になるよ。そりゃあ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_030022")

-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "笑い")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:気にしててよね。そのまま
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030023")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
-- ▼直接出力
 --PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:あまり興味ないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_030025")

	play_head_motion(Actor004, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ラグネル", "落胆")
-- ▲直接出力
	change_face(Actor004,"Sad")

	--★★ラグネル★★:…冷たいよノワール
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030026")

	play_head_motion(Actor003, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:ひでーな、ノワール
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_030027")

	play_head_motion(Actor002, "No", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:それはないわノワール
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030028")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:今日のランチおいしいな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_030030")

	play_head_motion(Actor003, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor003,"Smile")

	--★★ガウェイン★★:うめーよな
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_030031")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "激怒")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ラグネル★★:あのさあ！！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030032")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor003,"Normal")

	--★★ガウェイン★★:わり。ノワール現実逃避すんな<br>メシの話はいったん置いとこうぜ
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_030033")

	goto Block1end

::Block1end::
-- ▼直接出力
 --PlayPartVoice("ラグネル", "挨拶")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:ねえねえギネヴィア様！<br>その恋文、開いて見ました！？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030035")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ギネヴィア★★:もち
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030036")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ラグネル★★:なんて書いてあったんです！？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030037")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ノワール", "悩む")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:グイグイ行くな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","MA_01A111_030038")

	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:「ご一緒に　すこし遠出を　しませんか」
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030039")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "笑い")
-- ▲直接出力
	change_face(Actor004,"Smile")

	--★★ラグネル★★:わあ…！デートのお誘いですよね！？<br>それになんかリズミカルな文章で！！
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030040")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "落胆")
-- ▲直接出力
	change_face(Actor003,"Sad")

	--★★ガウェイン★★:ラグネル、落ち着けよ<br>お前が貰ったわけじゃねーんだから
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_030041")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "怒り")
-- ▲直接出力
	change_face(Actor004,"Anger")

	--★★ラグネル★★:誰からの手紙です！？<br>ガウェイン、あんたからじゃないよね！？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030042")

-- ▼直接出力
 --PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力

	--★★ガウェイン★★:んなワケねーだろ！！<br>はしゃぐなはしゃぐな！！
	Talk(Actor003,"CHRNAME_GAWAIN","speech","L","MA_01A111_030043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ギネヴィア★★:わかってる、わかってんのよ<br>わかりきってんのよ、差出人は
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030044")

-- ▼直接出力
 --PlayPartVoice("ラグネル", "驚き")
-- ▲直接出力
	change_face(Actor004,"Surprise")

	--★★ラグネル★★:え！？
	Talk(Actor004,"CHRNAME_RAGNAR","speech","L","MA_01A111_030045")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "落胆")
-- ▲直接出力

	--★★ギネヴィア★★:見覚えがありすぎるもの、この手紙<br>文字も綺麗、折り目も丁寧…丸わかりよ
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030046")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
 --PlayPartVoice("ギネヴィア", "照れ")
-- ▲直接出力
	change_face(Actor002,"Shy")

	--★★ギネヴィア★★:手渡しに行こうかな。お返事は
	Talk(Actor002,"CHRNAME_GUINEVERE","speech","L","MA_01A111_030047")

	EndPlay()
end



function PreLoad()
	PreLoad_AutoGenerate()
	
	-- 手動追加時はここの下に追加してください。
end

function PreLoad_AutoGenerate()
--luaのインポート時にPreLoadする対象をLoadから自動検出して追加する
 lookAtWeight = {0.4, 0.08, 0.7, 0.6}
	InitializeLoad_Preload()
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101011","001","101011001","content_animationpack__common","FacialPack","Actor002")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor003")
	InitializeCharacter_3D_Preload("101018","001","101018001","content_animationpack__common","FacialPack","Actor004")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor004,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor003,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
