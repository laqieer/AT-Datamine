-- このluaスクリプトは、CO_101013_0002.csvから自動生成されました --
Include("content_luascript_common","ADVSmallPack")
Include("content_adv_advsmall_110122_01","110122_01_h")
Include("content_adv_advsmall_110122_01","Template110122_01_h")
function template1()
	ResetCharaCamera()
	ResetRandomCamera()
	Camera001 = SetTemplate("Actor001",nil,CharaPos110122_01_003,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_003)
	Camera002 = SetTemplate("Actor002",nil,CharaPos110122_01_004,"content_motion3d_advarea_common_adv_templatecontroller","Com_m_SitController","to Sit01_Loop",CameraAssetBundleName110122_01,CameraPos110122_01_004)
	InitializeTemplateRandomCamera110122_01()
	InitializeTemplate110122_01()
end

function Load()
	InitializeLoad()
	manager = CreateAdvSmallManager()
	load_area_scene(110122)
	Actor001 = InitializeCharacter_3D("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	Actor002 = InitializeCharacter_3D("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	template1()
	load_head_animation(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation(Actor001,"content_animationpack__common", "HeadPack")
end

function Play()
	StartPlay()

-- ▼直接出力
setup_small_camera_start(RndCamera003)
-- ▲直接出力
	play_head_motion(Actor002, "No", 0.3, 1.0, false)
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:あ～、腹減った～！！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010008")


	--★★ノワール★★:ガウェインと食事でも、ってなると結局ここに行き着くんだよな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010009")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "怒り")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:なんだよ、不満なのか？ガレスの飯が食えねーってのか？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010010")

	play_head_motion(Actor001, "No", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "否定")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そんなこと言ってないだろ食堂のメニューはどれも美味いしな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010011")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "照れ")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:だよな！さっすが俺の妹だぜ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010012")

	change_face(Actor001,"Normal")

	--★★ノワール★★:いや、ガウェインの妹かどうかは関係ないんじゃないかな…
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010013")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いーや、関係ある！俺だって料理、作れるんだぜ？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010014")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:そうなのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010015")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:おう！俺の知ってる料理ガレスに教えたこともあるしな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010016")

-- ▼直接出力
setup_small_camera_start(RndCamera007)
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定3")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:へえ…どんな料理を教えたんだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010017")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:焼きウナギだろ、焼きタラだろそれから焼きサーモン…
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010018")

-- ▼直接出力
PlayPartVoice("ノワール", "驚き")
-- ▲直接出力
	change_face(Actor001,"Surprise")

	--★★ノワール★★:全部焼き魚！？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010019")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:いや、サザエの壺焼きも教えたぞ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010020")

-- ▼直接出力
PlayPartVoice("ノワール", "悲しみ")
-- ▲直接出力
	change_face(Actor001,"Sad")

	--★★ノワール★★:どっちにしろ魚介料理ばっかりじゃないか…他の料理はできないのか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010021")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Normal")

	--★★ガウェイン★★:できないわけじゃねーけど得意なものっつったら魚介になっかな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010022")

	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
	change_face(Actor001,"Laugh")

	--★★ノワール★★:じゃあ、これを機に得意料理を増やしてみるっていうのはどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010023")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:おっ、悪くないなそれ！たとえばどんなのがいいと思う？
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010024")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	open_select_window_tag(Actor001,"Normal","CO_101013_00010025","CO_101013_00010026","CO_101013_00010027")
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
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:肉料理はどうだ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010029")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:肉か～、いいんじゃねーか！俺も肉好きだし！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010030")

	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:焼き方だけでも種類があるからいろんな肉料理覚えられそうだな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010031")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:確かに。あと肉を入れた料理って考えるともっと幅が広がりそうだ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010032")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:肉を入れた料理？…シチューとかか。あれも美味いよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010033")

-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:そうだ、新しい肉料理覚えたら味見係になってくれよ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010034")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor001, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ノワール", "笑い")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺でいいなら喜んで
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010035")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:頼んだぜ！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010036")

	goto Block1end

::Block1_2::
	CloseTalkWindow()
	change_face(Actor001,"Normal")

	--★★ノワール★★:野菜を使った料理…とか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010039")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "悩む")
-- ▲直接出力
	change_face(Actor002,"Sad")

	--★★ガウェイン★★:野菜か～…嫌いじゃねーけどもっとこうドカンとくるやつがいーんだよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010040")

	change_face(Actor002,"Normal")

	--★★ガウェイン★★:派手っつーか食いでがありそうっつーか
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010041")

-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Normal")

	--★★ノワール★★:確かにサラダとかはあまりお腹には溜まらないな
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010042")

	change_face(Actor001,"Smile")

	--★★ノワール★★:でも探せばガウェインが気に入る野菜料理があるかもしれないぞ？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010043")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定2")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:…そっか、そうだな！俺が知らないだけってことあるよな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010044")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:よし、じゃあノワールも一緒に探してくれ野菜料理！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010045")

	change_face(Actor001,"Surprise")

	--★★ノワール★★:えっ？俺も？（余計なこと言っちゃったか…？）
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010046")

	goto Block1end

::Block1_3::
	CloseTalkWindow()
-- ▼直接出力
PlayPartVoice("ノワール", "肯定")
-- ▲直接出力
	change_face(Actor001,"Laugh")

	--★★ノワール★★:パンを作ってみたらいいんじゃないか？
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010049")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ガウェイン", "驚き")
-- ▲直接出力
	change_face(Actor002,"Surprise")

	--★★ガウェイン★★:パンって…生地からってことか？それはやったことねーな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010050")

	change_face(Actor001,"Normal")

	--★★ノワール★★:難しいかもしれないけどそのぶん、やりがいはありそうな気がする
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010051")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "肯定")
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:そういう言葉を出されると俄然やりたくなってくるぜ
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010052")

-- ▼直接出力
setup_small_camera_end()
-- ▲直接出力
	change_face(Actor002,"Laugh")

	--★★ガウェイン★★:人間、チャレンジ精神を忘れたらそこで終わりだからな
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010053")

	play_head_motion(Actor002, "Nod", 0.3, 1.0, false)
-- ▼直接出力
PlayPartVoice("ガウェイン", "喜び")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:時間はかかるかもしれねーけど美味いパンを作って皆を驚かせてやる！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010054")

-- ▼直接出力
setup_small_camera_start()
-- ▲直接出力
-- ▼直接出力
PlayPartVoice("ノワール", "肯定2")
-- ▲直接出力
	change_face(Actor001,"Smile")

	--★★ノワール★★:俺も楽しみに待ってるよ
	Talk(Actor001,"CHRNAME_NOIR","speech","L","CO_101013_00010055")

-- ▼直接出力
PlayPartVoice("ガウェイン", "笑い")
-- ▲直接出力
	change_face(Actor002,"Smile")

	--★★ガウェイン★★:おう！ありがとな！
	Talk(Actor002,"CHRNAME_GAWAIN","speech","L","CO_101013_00010056")

	goto Block1end

::Block1end::
-- ▼直接出力
kizuna_gaugeup(Actor002,"ガウェイン")
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
	load_area_scene_preload(110122)
	InitializeCharacter_3D_Preload("101009","002","101009002","content_animationpack__common","FacialPack","Actor001")
	InitializeCharacter_3D_Preload("101013","001","101013001","content_animationpack__common","FacialPack","Actor002")
	load_head_animation_preload(Actor002,"content_animationpack__common", "HeadPack")
	load_head_animation_preload(Actor001,"content_animationpack__common", "HeadPack")
	system.PreLoadRequest(CameraAssetBundleName110122_01)
	system.PreLoadRequest("content_motion3d_advarea_common_adv_templatecontroller")
end
